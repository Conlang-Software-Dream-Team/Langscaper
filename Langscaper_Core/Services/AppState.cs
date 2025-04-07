using Langscaper_Core.Models;

namespace Langscaper_Core.Services
{

    public static class AppState
    {
        public static Action<LanguageModel> OnCurrentLanguageChange;

        private static LanguageModel _currentLanguage;
        public static LanguageModel CurrentLanguage
        {
            get => _currentLanguage;
            set
            {
                if (_currentLanguage != value)
                {
                    _currentLanguage = value;
                    OnCurrentLanguageChange?.Invoke(_currentLanguage);  // Déclenche l'événement
                }
            }
        }
    }

}
