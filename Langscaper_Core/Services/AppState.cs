using Langscaper_Core.Models;

namespace Langscaper_Core.Services
{

    public  class AppState
    {
        public  Action<LanguageModel> OnCurrentLanguageChange;

        private  LanguageModel _currentLanguage;
        public  LanguageModel CurrentLanguage
        {
            get => _currentLanguage;
            set
            {
                if (_currentLanguage != value)
                {
                    _currentLanguage = value;
                    OnCurrentLanguageChange?.Invoke(_currentLanguage);  
                }
            }
        }
    }

}
