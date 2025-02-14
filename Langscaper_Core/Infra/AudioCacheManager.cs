namespace Langscaper_Core.Infra
{
    public class AudioCacheManager
    {
        private Dictionary<string, byte[]> cache = new();

        public async Task PreloadAudioAsync(string fileName)
        {

            if (cache.ContainsKey(fileName))
                return;

            var data = await File.ReadAllBytesAsync(fileName);
            cache[fileName] = data;
        }

        public byte[]? GetAudio(string fileName)
        {
            return cache.TryGetValue(fileName, out var data) ? data : null;
        }
    }
}
