using Langscaper_Core.Phonology;
using Langscaper_Core.Phonology.Diacritics;

namespace Langscaper_Core.Models
{
    public class PhonemeModel
    {
        public Phoneme phonem { get; set; }
        public ArticulationPlaceModification articulationPlaceModification { get; set; }
        public RoundnessModification roundnessModification { get; set; }
        public TonguePositionModification tonguePositionModification { get; set; }
        public TongueRootPositionModification tongueRootPositionModification { get; set; }
        public PhonationModification phonationProcessModification { get; set; }
        public OronasalProcessModification oronasalProcessModification { get; set; }
        public SyllabicRoleModification syllabicRoleModification { get; set; }
    }
}
