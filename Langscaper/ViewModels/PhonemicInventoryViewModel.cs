using CSP.ViewModels;
using System.Collections.ObjectModel;
using Phonology;
using System.Linq;
using System;
namespace Langscaper.ViewModels
{

    public partial class PhonemicInventoryViewModel : ViewModelBase
    {
        public ObservableCollection<VowelsTemplate> Vowels { get; }
        public ObservableCollection<PulmonicConsonantTemplate> PulmonicConsonants { get; }

        public PhonemicInventoryViewModel()
        {
            Vowels = new ObservableCollection<VowelsTemplate>(
                Phonem.vowels.Select(p => new VowelsTemplate(p))
            );

            PulmonicConsonants = new ObservableCollection<PulmonicConsonantTemplate>(
                Phonem.PulmonicConsonants.Select(p => new PulmonicConsonantTemplate(p))

            );

        }
    }


    public class VowelsTemplate
    {
        public string Ipa { get; }
        public int Row { get; }
        public int Column { get; }

        public VowelsTemplate(Phonem p)
        {
            Ipa = p.ipa;
            Row = GetRow(p);
            Column = GetColumn(p);
        }

        private int GetRow(Phonem phonem)
        {
            return phonem switch
            {
                _ when Phonem.close.Contains(phonem) => 1,
                _ when Phonem.nearClose.Contains(phonem) => 2,
                _ when Phonem.closeMid.Contains(phonem) => 3,
                _ when Phonem.mid.Contains(phonem) => 4,
                _ when Phonem.OpenMid.Contains(phonem) => 5,
                _ when Phonem.nearOpen.Contains(phonem) => 6,
                _ when Phonem.Open.Contains(phonem) => 7,
                _ => 0
            };
        }
        private int GetColumn(Phonem phonem)
        {
            return phonem switch
            {
                _ when Phonem.front.Contains(phonem) => 1,
                _ when Phonem.Central.Contains(phonem) => 2,
                _ when Phonem.Back.Contains(phonem) => 3,
                _ => 0
            };
        }
    }

    public class PulmonicConsonantTemplate 
    {
        public string Ipa { get; }
        public int Row { get; }
        public int Column { get; }

        public PulmonicConsonantTemplate(Phonem p)
        {
            Ipa = p.ipa;
            Row = GetRow(p);
            Column = GetColumn(p);
        }

        private int GetRow(Phonem phonem)
        {
            return phonem switch
            {
                _ when Phonem.Plosive.Contains(phonem) => 1,
                _ when Phonem.Nasal.Contains(phonem) => 2,
                _ when Phonem.Trill.Contains(phonem) => 3,
                _ when Phonem.TapOrFlap.Contains(phonem) => 4,
                _ when Phonem.Fricative.Contains(phonem) => 5,
                _ when Phonem.LateralFricative.Contains(phonem) => 6,
                _ when Phonem.Approximant.Contains(phonem) => 7,
                _ when Phonem.LateralApproximant.Contains(phonem) => 8,
                _ => 0
            };
        }
        private int GetColumn(Phonem phonem)
        {
            return phonem switch
            {
                _ when Phonem.Bilabial.Contains(phonem) => 1,
                _ when Phonem.Labiodental.Contains(phonem) => 2,
                _ when Phonem.Dental.Contains(phonem) => 3,
                _ when Phonem.Alveolar.Contains(phonem) => 4,
                _ when Phonem.PostAlveolar.Contains(phonem) => 5,
                _ when Phonem.Retroflex.Contains(phonem) => 6,
                _ when Phonem.Palatal.Contains(phonem) => 7,
                _ when Phonem.Velar.Contains(phonem) => 8,
                _ when Phonem.Uvular.Contains(phonem) => 9,
                _ when Phonem.Pharyngeal.Contains(phonem) => 10,
                _ when Phonem.Glottal.Contains(phonem) => 11,
                _ => 0
            };
        }
    }
}