

namespace Langscaper_Core.Phonology.Diacritics
{

    public enum ArticulationPlaceModification
    {
        Dental,
        Apical,
        Laminal,
        Linguolabial,
        Labialized,
        Palatalized,
        Velarized,
        Pharyngealized,
        Glottalized,
        None
    }
    public enum RoundnessModification
    {
        MoreRounded,
        LessRounded,
        None
    }
  
    public enum TonguePositionModification
    {
        Advanced,
        Retracted,
        Centralized,
        MidCentralized,
        None
    }
    public enum PhonationModification
    {
        Voiceless,
        Voiced,
        BreathyVoiced,
        CreakyVoiced,
        None
    }
    public enum OronasalProcessModification
    {
        Aspirated,
        Nasalized,
        NasalRelease,
        LateralRelease,
        NoAudibleRelease
    }
    public enum TongueRootPositionModification
    {
        AdvancedTongueRoot,
        RetractedTongueRoot,
        Raised,
        Lowered,
        None
    }
    public enum SyllabicRoleModification
    {
        Syllabic,
        NonSyllabic,
        None
    }
}
