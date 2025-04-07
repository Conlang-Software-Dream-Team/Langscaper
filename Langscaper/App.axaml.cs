using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using CSP.ViewModels;
using CSP.Views;
using Langscaper.ViewModels;
using Langscaper.Views;
using Langscaper_Core.Services;

namespace CSP;

public partial class App : Application
{
    private MainWindow mainWindow;

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Line below is needed to remove Avalonia data validation.
            // Without this line you will get duplicate validations from both Avalonia and CT
            BindingPlugins.DataValidators.RemoveAt(0);

            AppState state = new AppState();
            state.CurrentLanguage =  new Langscaper_Core.Models.LanguageModel();
            state.CurrentLanguage.Name = "Default name";

            mainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(state)
            };

            var splashScreen = new SplashscreenWindow
            {
                DataContext = new SplashscreenWindowViewModel(() => ShowMainWindow(desktop))
            };

            desktop.MainWindow = splashScreen;
        }

        base.OnFrameworkInitializationCompleted();
    }

    private void ShowMainWindow(IClassicDesktopStyleApplicationLifetime desktop)
    {
        if (mainWindow != null)
        {
            mainWindow.Show();
        }

        if (desktop.MainWindow is SplashscreenWindow splash)
            splash.Close();

        desktop.MainWindow = mainWindow;
    }
}