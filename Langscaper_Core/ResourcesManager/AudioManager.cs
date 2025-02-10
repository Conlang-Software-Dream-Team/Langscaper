using System.Diagnostics;

namespace Langscaper_Core.ResourcesManager.Audio
{
    public static class AudioManager
    {
        private static readonly string VLC_PATH = Path.Combine(AppContext.BaseDirectory, "Libs", "win64", "VLC", "vlc.exe");

        public static void PlayAudio(string filePath)
        {
            if (filePath == "") return;
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Can't play audio, file not found : {filePath}");

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = VLC_PATH,
                    Arguments = $"-I dummy --no-repeat --no-loop --play-and-exit \"{filePath}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
             process.Start();
        }
    }
}

