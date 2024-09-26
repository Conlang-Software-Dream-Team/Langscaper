namespace CSP_Core.Phonology;

public enum PlaceOfArticulation
{
    Bilabial,
    LabioDental,
    LinguoLabial,
    Dental,
    Alveolar,
    PostAlveolar,
    Retroflex,
    Palatal,
    Velar,
    Uvular,
    PharyngealOrEpiglotal,
    Glottal
}

public enum MannerOfArticulation
{
    Nasal,
    Plosive,
    SibilantAffricate,
    NonSibilantAffricate,
    SibilantFricative,
    NonSibilantFricative,
    Approximant,
    TapOrFlap,
    Trill,
    LateralAffricate,
    LateralFricative,
    LateralApproximant,
    LateralTapOrFlap

}

public enum Voicing
{
    Voiced,
    Voiceless,
    Undefined
}

public enum Mechanism
{
    Pulmonic,
    Ejective,
    Click,
    Imposive
}

public enum Sonorance
{
    Sonorant,
    Obstruent,
    Undefined
}

public readonly record struct Consonant(string Symbol, PlaceOfArticulation PlaceOfArticulation, Voicing Voicing, Mechanism Mechanism, Sonorance Sonorance)
{
    // From https://en.wikipedia.org/wiki/List_of_consonants
    public static Consonant VoicelessBilabialNasalStop = new("m̥", PlaceOfArticulation.Bilabial, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
    public static Consonant VoicedBilabialNasal = new("m", PlaceOfArticulation.Bilabial, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
    public static Consonant VoicelessLabioDentalNasalStop = new("ɱ̊", PlaceOfArticulation.LabioDental, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);

    public static List<Consonant> AllConsonants =
    [
        VoicelessBilabialNasalStop,
        VoicedBilabialNasal,
        VoicelessLabioDentalNasalStop
    ];
}