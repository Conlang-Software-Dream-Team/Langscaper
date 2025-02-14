using Avalonia.Threading;
using CSP.ViewModels;
using Langscaper_Core;
using Langscaper_Core.Infra;
using Langscaper_Core.Infra.Audio;
using Langscaper_Core.Services;
using Langscaper_Core.System.FileSystem;
using System;
using System.Threading.Tasks;

namespace Langscaper.ViewModels
{
    public class SplashscreenWindowViewModel : ViewModelBase
    {
        private readonly Action onLoadingComplete;
        private double progress;

        public double Progress
        {
            get => progress;
            set => SetProperty(ref progress, value);
        }

        public SplashscreenWindowViewModel(Action onLoadingComplete)
        {
            this.onLoadingComplete = onLoadingComplete;
            InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            var progress = new Progress<int>(value => Progress = value);
            int step = 0;
            int totalSteps = 4; // Nombre d'étapes réelles

            await Task.Run(async () =>
            {
                var audioCacheManager = new AudioCacheManager();
                step++;
                ((IProgress<int>)progress).Report((step * 100) / totalSteps);

                var audioPlayer = new AudioPlayer(audioCacheManager);
                step++;
                ((IProgress<int>)progress).Report((step * 100) / totalSteps);

                var fileManager = new FileManager(AppSettings.AudioDirectory);
                AudioServiceProvider.ConfigureServices(audioPlayer, fileManager);
                step++;
                ((IProgress<int>)progress).Report((step * 100) / totalSteps);

                await Task.Delay(500); // Pause avant d'afficher la MainWindow
                step++;
                ((IProgress<int>)progress).Report((step * 100) / totalSteps);
            });

            Dispatcher.UIThread.Post(() =>
            {
                onLoadingComplete?.Invoke();
            });
        }

    }
}
