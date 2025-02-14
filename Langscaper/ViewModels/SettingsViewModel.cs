using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CSP;
using CSP.ViewModels;
using Langscaper_Core;
using System.IO;


namespace Langscaper.ViewModels
{
    public partial class SettingsViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string vlcPath;
        private bool CanSave() => !string.IsNullOrWhiteSpace(VlcPath) && File.Exists(VlcPath);

        public SettingsViewModel()
        {
            VlcPath = AppSettings.VlcPath;
        }

        [RelayCommand]
        public async void BrowseForVlcPath()
        {
            var topLevel = GetMainWindow();
            if (topLevel is null) return;

            var storageProvider = topLevel.StorageProvider;
            var files = await storageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
            {
                Title = "Select VLC executable",
                AllowMultiple = false
            });

            if (files.Count > 0)
                VlcPath = files[0].Path.LocalPath;
        }


        private static Window? GetMainWindow()
        {
            if (App.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktopLifetime)
            {
                return desktopLifetime.MainWindow;
            }
            return null;
        }

        [RelayCommand(CanExecute = nameof(CanSave))]
        private void SaveSettings()
        {
            AppSettings.VlcPath = VlcPath;
            AppSettings.SaveSettings();
        }
        partial void OnVlcPathChanged(string value)
        {
            SaveSettingsCommand.NotifyCanExecuteChanged();
        }
    }
}
