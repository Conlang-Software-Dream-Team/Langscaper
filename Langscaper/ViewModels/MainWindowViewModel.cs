using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CSP.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string ConlangName => "My Conlang Name";

    [ObservableProperty]
    private bool _isSidePanelOpen = false;

    [RelayCommand]
    public void ToggleSidePanel() 
    {
        IsSidePanelOpen = !IsSidePanelOpen;
    }
}