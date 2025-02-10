using Langscaper_Core.ResourcesManager.Audio;
using Langscaper_Core.ResourcesManager.FileSystem;

namespace Langscaper_Core.Phonology
{

    public static class PhonemeAudioService
    {
        private static readonly Dictionary<string, string> phonemeToFile = new()
        {
            { "m", "IPA\\Bilabial_nasal.ogg" },
            { "ɱ", "IPA\\Labiodental_nasal.ogg" },
            { "n", "IPA\\Alveolar_nasal.ogg" },
            { "ɳ", "IPA\\Retroflex_nasal.ogg" },
            { "ɲ", "IPA\\Palatal_nasal.ogg" },
            { "ŋ", "IPA\\Velar_nasal.ogg" },
            { "ɴ", "IPA\\Uvular_nasal.ogg" },
            { "p", "IPA\\Voiceless_bilabial_plosive.ogg" },
            { "b", "IPA\\Voiced_bilabial_plosive.ogg" },
            { "t", "IPA\\Voiceless_alveolar_plosive.ogg" },
            { "d", "IPA\\Voiced_alveolar_plosive.ogg" },
            { "ʈ", "IPA\\Voiceless_retroflex_plosive.ogg" },
            { "ɖ", "IPA\\Voiced_retroflex_plosive.ogg" },
            { "c", "IPA\\Voiceless_palatal_plosive.ogg" },
            { "ɟ", "IPA\\Voiced_palatal_plosive.ogg" },
            { "k", "IPA\\Voiceless_velar_plosive.ogg" },
            { "g", "IPA\\Voiced_velar_plosive.ogg" },
            { "q", "IPA\\Voiceless_uvular_plosive.ogg" },
            { "ɢ", "IPA\\Voiced_uvular_plosive.ogg" },
            { "ʔ", "IPA\\Glottal_stop.ogg" },
            { "ɸ", "IPA\\Voiceless_bilabial_fricative.ogg" },
            { "β", "IPA\\Voiced_bilabial_fricative.ogg" },
            { "f", "IPA\\Voiceless_labiodental_fricative.ogg" },
            { "v", "IPA\\Voiced_labiodental_fricative.ogg" },
            { "θ", "IPA\\Voiceless_dental_fricative.ogg" },
            { "ð", "IPA\\Voiced_dental_fricative.ogg" },
            { "s", "IPA\\Voiceless_alveolar_fricative.ogg" },
            { "z", "IPA\\Voiced_alveolar_fricative.ogg" },
            { "ʃ", "IPA\\Voiceless_postalveolar_fricative.ogg" },
            { "ʒ", "IPA\\Voiced_postalveolar_fricative.ogg" },
            { "ʂ", "IPA\\Voiceless_retroflex_fricative.ogg" },
            { "ʐ", "IPA\\Voiced_retroflex_fricative.ogg" },
            { "ç", "IPA\\Voiceless_palatal_fricative.ogg" },
            { "ʝ", "IPA\\Voiced_palatal_fricative.ogg" },
            { "x", "IPA\\Voiceless_velar_fricative.ogg" },
            { "ɣ", "IPA\\Voiced_velar_fricative.ogg" },
            { "χ", "IPA\\Voiceless_uvular_fricative.ogg" },
            { "ʁ", "IPA\\Voiced_uvular_fricative.ogg" },
            { "ħ", "IPA\\Voiceless_pharyngeal_fricative.ogg" },
            { "ʕ", "IPA\\Voiced_pharyngeal_fricative.ogg" },
            { "h", "IPA\\Voiceless_glottal_fricative.ogg" },
            { "ɦ", "IPA\\Voiced_glottal_fricative.ogg" },
            { "ʋ", "IPA\\Labiodental_approximant.ogg" },
            { "ɹ", "IPA\\Alveolar_approximant.ogg" },
            { "ɻ", "IPA\\Retroflex_approximant.ogg" },
            { "j", "IPA\\Palatal_approximant.ogg" },
            { "ɰ", "IPA\\Velar_approximant.ogg" },
            { "ʙ", "IPA\\Bilabial_trill.ogg" },
            { "r", "IPA\\Alveolar_trill.ogg" },
            { "ʀ", "IPA\\Uvular_trill.ogg" },
            { "ɾ", "IPA\\Alveolar_tap.ogg" },
            { "ɽ", "IPA\\Retroflex_tap.ogg" },
            { "ɬ", "IPA\\Voiceless_alveolar_lateral_fricative.ogg" },
            { "ɮ", "IPA\\Voiced_alveolar_lateral_fricative.ogg" },
            { "l", "IPA\\Alveolar_lateral_approximant.ogg" },
            { "ɭ", "IPA\\Retroflex_lateral_approximant.ogg" },
            { "ʎ", "IPA\\Palatal_lateral_approximant.ogg" },
            { "ʟ", "IPA\\Velar_lateral_approximant.ogg" },
            { "i", "IPA\\Close_front_unrounded_vowel.ogg" },
            { "y", "IPA\\Close_front_rounded_vowel.ogg" },
            { "ɨ", "IPA\\Close_central_unrounded_vowel.ogg" },
            { "ʉ", "IPA\\Close_central_rounded_vowel.ogg" },
            { "ɯ", "IPA\\Close_back_unrounded_vowel.ogg" },
            { "u", "IPA\\Close_back_rounded_vowel.ogg" },
            { "ɪ", "IPA\\Near-close_near-front_unrounded_vowel.ogg" },
            { "ʏ", "IPA\\Near-close_near-front_rounded_vowel.ogg" },
            { "ʊ", "IPA\\Near-close_near-back_rounded_vowel.ogg" },
            { "e", "IPA\\Close-mid_front_unrounded_vowel.ogg" },
            { "ø", "IPA\\Close-mid_front_rounded_vowel.ogg" },
            { "ɘ", "IPA\\Close-mid_central_unrounded_vowel.ogg" },
            { "ɵ", "IPA\\Close-mid_central_rounded_vowel.ogg" },
            { "ɤ", "IPA\\Close-mid_back_unrounded_vowel.ogg" },
            { "o", "IPA\\Close-mid_back_rounded_vowel.ogg" },
            { "ə", "IPA\\Mid_central_vowel.ogg" },
            { "ɛ", "IPA\\Open-mid_front_unrounded_vowel.ogg" },
            { "œ", "IPA\\Open-mid_front_rounded_vowel.ogg" },
            { "ɜ", "IPA\\Open-mid_central_unrounded_vowel.ogg" },
            { "ɞ", "IPA\\Open-mid_central_rounded_vowel.ogg" },
            { "ʌ", "IPA\\Open-mid_back_unrounded_vowel.ogg" },
            { "ɔ", "IPA\\Open-mid_back_rounded_vowel.ogg" },
            { "æ", "IPA\\Near-open_front_unrounded_vowel.ogg" },
            { "ɐ", "IPA\\Near-open_central_unrounded_vowel.ogg" },
            { "a", "IPA\\Open_front_unrounded_vowel.ogg" },
            { "ɶ", "IPA\\Open_front_rounded_vowel.ogg" },
            { "ɑ", "IPA\\Open_back_unrounded_vowel.ogg" },
            { "ɒ", "IPA\\Open_back_rounded_vowel.ogg" }
};

        public static event Action<string>? OnErrorLogged;


        public static void PlayPhoneme(string phoneme)
        {
            try
            {
                if (!phonemeToFile.TryGetValue(phoneme, out string? fileName) || fileName is null)
                {
                    throw new KeyNotFoundException($"[PhonemAudioService] No audio file found for the phoneme: {phoneme}");
                }
                string filePath = FileManager.GeAudiotFilePath(fileName);
                AudioManager.PlayAudio(filePath);
            }
            catch (KeyNotFoundException e)
            {
                OnErrorLogged?.Invoke(e.Message);
            }
        }
    }

}

