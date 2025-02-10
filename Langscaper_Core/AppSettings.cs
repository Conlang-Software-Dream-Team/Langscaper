using System.Text.Json;

namespace Langscaper_Core
{
    public static class AppSettings
    {
        private static readonly string ConfigFilePath = Path.Combine(AppContext.BaseDirectory, "config.json");

        public static string VlcPath { get; set; } = Path.Combine(AppContext.BaseDirectory, "Libs", "win64", "VLC", "vlc.exe");

        public static void LoadSettings()
        {
            if (File.Exists(ConfigFilePath))
            {
                var json = File.ReadAllText(ConfigFilePath);
                var settings = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
                if (settings != null && settings.ContainsKey("VlcPath"))
                {
                    VlcPath = settings["VlcPath"];
                }
            }
        }

        public static void SaveSettings()
        {
            var settings = new Dictionary<string, string> { { "VlcPath", VlcPath } };
            var json = JsonSerializer.Serialize(settings);
            File.WriteAllText(ConfigFilePath, json);
        }
    }

}