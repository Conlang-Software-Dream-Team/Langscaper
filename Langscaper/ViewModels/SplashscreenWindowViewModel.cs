using System;
using System.Threading.Tasks;
using Avalonia.Threading;
using CSP.ViewModels;
using Langscaper_Core.Phonology;

namespace Langscaper.ViewModels
{
    public class SplashScreenWindowViewModel : ViewModelBase
    {
        private readonly Action _onLoadingComplete;
        private double _progress;

        public double Progress
        {
            get => _progress;
            set => SetProperty(ref _progress, value);
        }

        public SplashScreenWindowViewModel(Action onLoadingComplete)
        {
            _onLoadingComplete = onLoadingComplete;
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            AudioServiceProvider.ConfigureServices();

            // Simulation d'un chargement
            await Task.Run(async () =>
            {
                for (int i = 0; i <= 100; i += 5)
                {
                    Progress = i;
                    await Task.Delay(100);
                }
            });

            await Task.Delay(500); // Pause avant d'afficher la MainWindow

            Dispatcher.UIThread.Post(() =>
            {
                _onLoadingComplete?.Invoke();
            });
        }
    }
}
