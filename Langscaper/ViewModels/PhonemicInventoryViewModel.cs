using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CSP.ViewModels;
using Langscaper_Core.Phonology;
using Langscaper_Core.Phonology.Diacritics;
using Langscaper_Core.Services;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Langscaper.ViewModels
{
    public partial class PhonemicInventoryViewModel : ViewModelBase
    {
        public Action RefreshGrids;

        [ObservableProperty]
        private bool _isRarityEnabled;

        [ObservableProperty]
        private bool _isSonorantEnabled;

        partial void OnIsRarityEnabledChanged(bool value)
        {
            RefreshGrids?.Invoke();
        }
        partial void OnIsSonorantEnabledChanged(bool value)
        {
            RefreshGrids?.Invoke();
        }

        public ObservableCollection<VowelsTemplate> Vowels { get; }
        public ObservableCollection<ConsonantTemplate> Consonants { get; }

        public PhonemicInventoryViewModel()
        {
            Vowels = new ObservableCollection<VowelsTemplate>(
                PhonemeCategories.Vowels.Select(p => new VowelsTemplate(p))
            );

            Consonants = new ObservableCollection<ConsonantTemplate>(
                PhonemeCategories.Consonants.Select(p => new ConsonantTemplate(p))

            );
        }

    }

    public abstract class PhonemTemplate
    {
        public string Ipa { get; }
        public byte Rarity { get; }
        public bool IsSonorant { get; }

        public ArticulationPlaceModification articulationPlaceModification;
        public SyllabicRole syllabicRole { get; }


        public int Row { get; }
        public int Column { get; }

        public ICommand PlaySoundCommand { get; }

        public PhonemTemplate(Phoneme p)
        {
            PhonemeNotationService.PhonemeToIPA.TryGetValue(p, out var ipa);
            Ipa = ipa;

            PhonemeRarityService.PhonemeToRarity.TryGetValue(p, out var rarity);
            Rarity = rarity;
            IsSonorant = PhonemeCategories.Sonorants.Contains(p);

            Row = GetRow(p);
            Column = GetColumn(p);
            PlaySoundCommand = new RelayCommand(PlaySound);
        }

        private void PlaySound()
        {
            PhonemeAudioService.PlayPhoneme(Ipa);
        }
        protected abstract int GetColumn(Phoneme p);
        protected abstract int GetRow(Phoneme p);
    }

    public class VowelsTemplate : PhonemTemplate
    {
        public RoundnessModification roundnessModification;
        public TongueRootPosition tongueRootPosition;
        public TonguePosition tonguePosition;

        public VowelsTemplate(Phoneme p) : base(p) { }

        protected override int GetRow(Phoneme phonem)
        {
            return phonem switch
            {
                _ when PhonemeCategories.close.Contains(phonem) => 1,
                _ when PhonemeCategories.nearClose.Contains(phonem) => 2,
                _ when PhonemeCategories.closeMid.Contains(phonem) => 3,
                _ when PhonemeCategories.mid.Contains(phonem) => 4,
                _ when PhonemeCategories.OpenMid.Contains(phonem) => 5,
                _ when PhonemeCategories.nearOpen.Contains(phonem) => 6,
                _ when PhonemeCategories.Open.Contains(phonem) => 7,
                _ => 0
            };
        }
        protected override int GetColumn(Phoneme phonem)
        {
            return phonem switch
            {
                _ when PhonemeCategories.front.Contains(phonem) => 1,
                _ when PhonemeCategories.Central.Contains(phonem) => 2,
                _ when PhonemeCategories.Back.Contains(phonem) => 3,
                _ => 0
            };
        }
    }

    public class ConsonantTemplate : PhonemTemplate
    {
        public MannerModification mannerModification;
        public PhonationProcess phonationDiacritic;
        public OronasalProcess releaseNasalization;

        public ConsonantTemplate(Phoneme p) : base(p) { }

        protected override int GetRow(Phoneme phonem)
        {
            return phonem switch
            {
                _ when PhonemeCategories.Plosive.Contains(phonem) => 1,
                _ when PhonemeCategories.Nasals.Contains(phonem) => 2,
                _ when PhonemeCategories.Trill.Contains(phonem) => 3,
                _ when PhonemeCategories.TapOrFlap.Contains(phonem) => 4,
                _ when PhonemeCategories.Fricative.Contains(phonem) => 5,
                _ when PhonemeCategories.LateralFricative.Contains(phonem) => 6,
                _ when PhonemeCategories.Approximant.Contains(phonem) => 7,
                _ when PhonemeCategories.LateralApproximant.Contains(phonem) => 8,
                _ => 0
            };
        }

        protected override int GetColumn(Phoneme phonem)
        {
            return phonem switch
            {
                _ when PhonemeCategories.Bilabial.Contains(phonem) => 1,
                _ when PhonemeCategories.Labiodental.Contains(phonem) => 2,
                _ when PhonemeCategories.Dental.Contains(phonem) => 3,
                _ when PhonemeCategories.Alveolar.Contains(phonem) => 4,
                _ when PhonemeCategories.PostAlveolar.Contains(phonem) => 5,
                _ when PhonemeCategories.Retroflex.Contains(phonem) => 6,
                _ when PhonemeCategories.Palatal.Contains(phonem) => 7,
                _ when PhonemeCategories.Velar.Contains(phonem) => 8,
                _ when PhonemeCategories.Uvular.Contains(phonem) => 9,
                _ when PhonemeCategories.Pharyngeal.Contains(phonem) => 10,
                _ when PhonemeCategories.Glottal.Contains(phonem) => 11,
                _ => 0
            };
        }
    }

}