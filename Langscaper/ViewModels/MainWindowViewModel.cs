using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Media;
using Avalonia.Platform.Storage;
using Avalonia.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CSP.Views;
using Langscaper.ViewModels;
using Langscaper.Views;
using Langscaper_Core.Models;
using Langscaper_Core.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CSP.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string? CurrentProjectPath;
    public string ConlangName => AppState.CurrentLanguage.Name;

    public ViewModelBase HomePage = new HomePageViewModel();

    [ObservableProperty]
    private bool _isSidePanelOpen = false;

    [ObservableProperty]
    private ViewModelBase _currentPage = new HomePageViewModel();


    [ObservableProperty]
    private ButtonIconTemplate _selectedSection;

    [ObservableProperty]
    private string _logMessage;

    partial void OnSelectedSectionChanged(ButtonIconTemplate value)
    {
        if (value is null) return;
        var instance = Activator.CreateInstance(value.ModelType);
        if (instance is null) return;

        CurrentPage = (ViewModelBase)instance;
    }

    public ObservableCollection<ButtonIconTemplate> ButtonIconList { get; } = new()
    {
        new ButtonIconTemplate(typeof(PhonemicInventoryViewModel), "speaker_edit_regular"),
        new ButtonIconTemplate(typeof(PhonotacticsViewModel), "speaker_settings_regular"),
        new ButtonIconTemplate(typeof(SyntaxViewModel), "text_change_accept_regular"),
        new ButtonIconTemplate(typeof(GrammarViewModel), "text_proofing_tools_regular"),
        new ButtonIconTemplate(typeof(WritingSystemViewModel),"text_edit_style_regular"),
        new ButtonIconTemplate(typeof(DocumentationViewModel), "document_regular")
    };

    public MainWindowViewModel()
    {
        //FileManager.OnErrorLogged += OnLogWritten;
        PhonemeAudioService.OnErrorLogged += OnLogWritten;
    }

    [RelayCommand]
    public void ToggleSidePanel()
    {
        IsSidePanelOpen = !IsSidePanelOpen;
    }

    [RelayCommand]
    public void GoToHomePage()
    {
        CurrentPage = HomePage;
    }

    [RelayCommand]
    public void OpenSettings()
    {
        var settingsWindow = new SettingsView();
        settingsWindow.Show();
    }

    [RelayCommand]
    public async Task SaveProject()
    {
        if (string.IsNullOrEmpty(CurrentProjectPath))
        {
            await SaveAsProject();
            return;
        }

        LanguageSerializer.Serialize(AppState.CurrentLanguage, CurrentProjectPath);
    }

    [RelayCommand]
    public async Task SaveAsProject()
    {
        var saveOptions = new FilePickerSaveOptions
        {
            Title = "Save as...",
            DefaultExtension = "conlang",
            FileTypeChoices = new List<FilePickerFileType>
                {
                    new FilePickerFileType("Conlang files")
                    {
                        Patterns = new List<string> { "*.conlang" }
                    }
                }
        };

        if (Application.Current?.ApplicationLifetime is not Avalonia.Controls.ApplicationLifetimes.IClassicDesktopStyleApplicationLifetime desktop)
            return;
        if (desktop.MainWindow is null) return;

        var storageProvider = desktop.MainWindow.StorageProvider;
        var result = await storageProvider.SaveFilePickerAsync(saveOptions);
        if (result != null)
        {
            // Tente de récupérer le chemin local
            var localPath = result.TryGetLocalPath();
            LanguageSerializer.Serialize(AppState.CurrentLanguage, localPath);
        }
    }

    private void OnLogWritten(string log)
    {
        LogMessage = log;
    }

    internal static void NavigateToMainView()
    {
        Dispatcher.UIThread.Post(() =>
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();

            if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                foreach (var window in desktop.Windows)
                {
                    if (window is SplashscreenWindow splashScreen)
                    {
                        splashScreen.Close();
                        break;
                    }
                }
            }
        });
    }
}

public class ButtonIconTemplate
{
    private string _label;
    private Type _modelType;
    private StreamGeometry _icon;
    public string Label => _label;
    public Type ModelType => _modelType;
    public StreamGeometry Icon => _icon;
    public ButtonIconTemplate(Type modeltype, string icon)
    {
        _modelType = modeltype;
        _label = _modelType.Name.Replace("ViewModel", "");
        Application.Current.TryFindResource(icon, out var resource);
        _icon = (StreamGeometry)resource;

    }
}