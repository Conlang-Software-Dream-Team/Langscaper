using Langscaper_Core.Models;
using System.Text.Json;

namespace Langscaper_Core.Services
{
    public class LanguageSerializer
    {
        private const string FileExtension = ".conlang";

        public static void Serialize(LanguageModel language, string directory)
        {
            if (language == null)
                throw new ArgumentNullException(nameof(language));

            string json = JsonSerializer.Serialize(language, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(directory, json);
        }

        public static LanguageModel Deserialize(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found", filePath);

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<LanguageModel>(json) ?? throw new InvalidOperationException("Deserialization failed");
        }
    }

}
