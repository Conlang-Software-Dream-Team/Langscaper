using CommunityToolkit.Mvvm.ComponentModel;
using Langscaper_Core.Services;
using System;

namespace CSP.ViewModels;

public class ViewModelBase : ObservableObject
{
    protected AppState state;
    internal void initialize(AppState appState)
    {
        state = appState;
    }
}