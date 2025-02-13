namespace Langscaper_Core.System
{
    public class AudioCacheManager
    {
        private static Dictionary<string, byte[]> cache = new();

        public static async Task PreloadAudioAsync(string fileName)
        {

            if (cache.ContainsKey(fileName))
                return;

            var data = await File.ReadAllBytesAsync(fileName);
            cache[fileName] = data;
        }

        public static byte[]? GetAudio(string fileName)
        {
            return cache.TryGetValue(fileName, out var data) ? data : null;
        }
    }
}
