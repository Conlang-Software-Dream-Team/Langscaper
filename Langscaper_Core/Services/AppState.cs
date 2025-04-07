using Langscaper_Core.Models;

namespace Langscaper_Core.Services
{

    public static class AppState
    {
        public static LanguageModel CurrentLanguage { get; set; } = new();
    }
}
