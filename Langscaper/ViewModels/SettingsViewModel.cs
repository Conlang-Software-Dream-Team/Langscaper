using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CSP;
using CSP.ViewModels;
using Langscaper_Core;
using Langscaper_Core.Services;


namespace Langscaper.ViewModels
{
    public partial class SettingsViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string conlangName;
        private AppState state;
        private bool CanSave() => true;

        public SettingsViewModel(AppState appState)
        {
            state = appState;
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
            AppSettings.SaveSettings();
            state.CurrentLanguage.Name = conlangName;
            state.OnCurrentLanguageChange?.Invoke(state.CurrentLanguage);
        }
   
    }
}
