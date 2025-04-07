using Avalonia.Controls;
using Langscaper.ViewModels;
using Langscaper_Core.Services;

namespace CSP.Views;

public partial class SettingsView : Window
{
    public SettingsView(AppState state)
    {
        InitializeComponent();
        DataContext = new SettingsViewModel(state);

    }
}