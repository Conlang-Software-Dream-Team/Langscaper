using Langscaper_Core.ResourcesManager.Audio;
using Langscaper_Core.ResourcesManager;

namespace Langscaper_Core.Phonology
{

    public static class PhonemeAudioService
    {
        private static readonly Dictionary<string, string> phonemeToFile = new()
    {
        { "m", "IPA//Bilabial_nasal.ogg" },
        { "s", "IPA//alveolar_fricative.ogg" },
    };

        public static void PlayPhoneme(string phoneme)
        {
            if (!phonemeToFile.TryGetValue(phoneme, out string? fileName))
                throw new KeyNotFoundException($"No audio file found for the phonem : {phoneme}");

            string filePath = FileManager.GeAudiotFilePath(fileName);
            AudioManager.PlayAudio(filePath);
        }
    }

}

