using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using CSP.ViewModels;
using CSP.Views;
using Langscaper.ViewModels;
using Langscaper.Views;

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

            mainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel()
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