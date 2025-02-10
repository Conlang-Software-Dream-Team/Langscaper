using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Langscaper.ViewModels;
using Langscaper_Core.Phonology;
using Langscaper_Core.ResourcesManager.FileSystem;
using System;
using System.Collections.ObjectModel;

namespace CSP.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string ConlangName => "My Conlang Name";
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

    private void OnLogWritten(string log)
    {
        LogMessage = log;
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