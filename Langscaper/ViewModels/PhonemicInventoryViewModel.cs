using CSP.ViewModels;
using System.Collections.ObjectModel;
using Phonology;
using System.Linq;
using System;
namespace Langscaper.ViewModels
{

    public partial class PhonemicInventoryViewModel : ViewModelBase
    {
        public ObservableCollection<PhonemViewModel> Vowels { get; }

        public PhonemicInventoryViewModel()
        {
            Vowels = new ObservableCollection<PhonemViewModel>(
                Phonem.vowels.Select(p => new PhonemViewModel(p))
            );

        }
    }


    public class PhonemViewModel
    {
        public string Ipa { get; }
        public int Row { get; }
        public int Column { get; }

        public PhonemViewModel(Phonem p)
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
                _ => 0            };
        }
    }
}