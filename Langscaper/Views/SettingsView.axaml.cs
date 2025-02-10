using Avalonia.Controls;
using Langscaper.ViewModels;

namespace CSP.Views;

public partial class SettingsView : Window
{
    public SettingsView()
    {
        InitializeComponent();
        DataContext = new SettingsViewModel();

    }
}