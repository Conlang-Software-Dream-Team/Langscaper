using CommunityToolkit.Mvvm.ComponentModel;
using CSP.ViewModels;
using Langscaper_Core.Models;
using Langscaper_Core.Services;
using System;

namespace Langscaper.ViewModels
{
    internal partial class HomePageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string conlangName;

        public HomePageViewModel(AppState appState) 
        {
            state = appState;
            state.OnCurrentLanguageChange += UpdateConlangData;
            conlangName = state.CurrentLanguage.Name;
        }

        private void UpdateConlangData(LanguageModel model)
        {
            ConlangName = model.Name;
        }
    }
}
