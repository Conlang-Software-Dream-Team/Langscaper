using Avalonia.Threading;
using CSP.ViewModels;
using Langscaper_Core;
using Langscaper_Core.Infra.Audio;
using Langscaper_Core.Services;
using Langscaper_Core.System.FileSystem;
using System;
using System.Threading.Tasks;

namespace Langscaper.ViewModels
{
    public class SplashscreenWindowViewModel : ViewModelBase
    {
        private readonly Action _onLoadingComplete;
        private double _progress;

        public double Progress
        {
            get => _progress;
            set => SetProperty(ref _progress, value);
        }

        public SplashscreenWindowViewModel(Action onLoadingComplete)
        {
            _onLoadingComplete = onLoadingComplete;
            InitializeAsync();
        }

        private async void InitializeAsync()
        {


            var audioPlayer = new AudioPlayer();
            var fileManager = new FileManager(AppSettings.AudioDirectory);
            AudioServiceProvider.ConfigureServices(audioPlayer, fileManager);

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
