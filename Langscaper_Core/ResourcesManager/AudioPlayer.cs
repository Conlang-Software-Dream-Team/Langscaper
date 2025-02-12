using System.Diagnostics;

namespace Langscaper_Core.ResourcesManager.Audio
{
    public static class AudioPlayer
    {
        public static void PlayAudio(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath)) return;
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Can't play audio, file not found: {filePath}");

            var vlcPath = AppSettings.VlcPath;
            if (!File.Exists(vlcPath))
                throw new FileNotFoundException($"VLC executable not found: {vlcPath}");

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = vlcPath,
                    Arguments = $"-I dummy --no-repeat --no-loop --play-and-exit \"{filePath}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            process.Start();
        }
    }
}
