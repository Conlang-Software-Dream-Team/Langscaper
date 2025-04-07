using Langscaper_Core.Models;

namespace Langscaper_Core.Services
{

    public class AppState
    {
        public LanguageModel CurrentLanguage { get; set; } = new();
    }
}
