namespace Langscaper_Core.ResourcesManager
{
    public class AudioCacheManager
    {
        private Dictionary<string, byte[]> audioCache = new();

        public async Task PreloadAudioAsync()
        {
            var files = Directory.GetFiles(AppSettings.AudioDirectory, @"\.(ogg|oga)$", SearchOption.TopDirectoryOnly);
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                var data = await File.ReadAllBytesAsync(file);
                audioCache[fileName] = data;
            }
        }

        public byte[]? GetAudio(string phoneme)
        {
            return audioCache.TryGetValue(phoneme, out var data) ? data : null;
        }

        public MemoryStream? GetAudioStream(string phoneme)
        {
            if (audioCache.TryGetValue(phoneme, out var data))
            {
                return new MemoryStream(data);
            }
            return null;
        }
    }
}
