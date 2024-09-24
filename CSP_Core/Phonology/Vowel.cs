namespace CSP_Core.Phonology;

public enum Height
{
    Close,
    NearClose,
    CloseMid,
    Mid,
    OpenMid,
    NearOpen,
    Open
}

public enum Backness
{
    Front,
    Central,
    Back
}

public enum Roundedness
{
    Rounded,
    Unrounded,
    Undefined
}

public readonly record struct Vowel(string Symbol, Height Height, Backness Backness, Roundedness Roundedness)
{
    // From https://en.wikipedia.org/wiki/Table_of_vowels
    public static Vowel CloseFrontUnrounded = new("i", Height.Close, Backness.Front, Roundedness.Unrounded);
    public static Vowel CloseFrontRounded = new("y", Height.Close, Backness.Front, Roundedness.Rounded);
    public static Vowel CloseCentralUnrounded = new("ɨ", Height.Close, Backness.Central, Roundedness.Unrounded);
    public static Vowel CloseCentralRounded = new("ʉ", Height.Close, Backness.Central, Roundedness.Rounded);
    public static Vowel CloseBackUnrounded = new("ɯ", Height.Close, Backness.Back, Roundedness.Unrounded);
    public static Vowel CloseBackRounded = new("u", Height.Close, Backness.Back, Roundedness.Rounded);

    public static Vowel NearCloseFrontUnrounded = new("ɪ", Height.NearClose, Backness.Front, Roundedness.Unrounded);
    public static Vowel NearCloseFrontRounded = new("ʏ", Height.NearClose, Backness.Front, Roundedness.Rounded);
    public static Vowel NearCloseBackRounded = new("ʊ", Height.NearClose, Backness.Back, Roundedness.Rounded);

    public static Vowel CloseMidFrontUnrounded = new("e", Height.CloseMid, Backness.Front, Roundedness.Unrounded);
    public static Vowel CloseMidFrontRounded = new("ø", Height.CloseMid, Backness.Front, Roundedness.Rounded);
    public static Vowel CloseMidCentralUnrounded = new("ɘ", Height.CloseMid, Backness.Central, Roundedness.Unrounded);
    public static Vowel CloseMidCentralRounded = new("ɵ", Height.CloseMid, Backness.Central, Roundedness.Rounded);
    public static Vowel CloseMidBackUnrounded = new("ɤ", Height.CloseMid, Backness.Back, Roundedness.Unrounded);
    public static Vowel CloseMidBackRounded = new("o", Height.CloseMid, Backness.Back, Roundedness.Rounded);

    public static Vowel MidCentral = new("ə", Height.Mid, Backness.Central, Roundedness.Undefined);

    public static Vowel OpenMidFrontUnrounded = new("ɛ", Height.OpenMid, Backness.Front, Roundedness.Unrounded);
    public static Vowel OpenMidFrontRounded = new("œ", Height.OpenMid, Backness.Front, Roundedness.Rounded);
    public static Vowel OpenMidCentralUnrounded = new("ɜ", Height.OpenMid, Backness.Central, Roundedness.Unrounded);
    public static Vowel OpenMidCentralRounded = new("ɞ", Height.OpenMid, Backness.Central, Roundedness.Rounded);
    public static Vowel OpenMidBackUnrounded = new("ʌ", Height.OpenMid, Backness.Back, Roundedness.Unrounded);
    public static Vowel OpenMidBackRounded = new("ɔ", Height.OpenMid, Backness.Back, Roundedness.Rounded);

    public static Vowel NearOpenFrontUnrounded = new("æ", Height.NearOpen, Backness.Front, Roundedness.Unrounded);
    public static Vowel NearOpenCentral = new("ɐ", Height.NearOpen, Backness.Central, Roundedness.Undefined);

    public static Vowel OpenFrontUnrounded = new("a", Height.Open, Backness.Front, Roundedness.Unrounded);
    public static Vowel OpenFrontRounded = new("ɶ", Height.Open, Backness.Front, Roundedness.Rounded);
    public static Vowel OpenBackUnrounded = new("ɑ", Height.Open, Backness.Back, Roundedness.Unrounded);
    public static Vowel OpenBackRounded = new("ɒ", Height.Open, Backness.Back, Roundedness.Rounded);

    public static List<Vowel> AllVowels =
    [
        CloseFrontUnrounded,
        CloseFrontRounded,
        CloseCentralUnrounded,
        CloseCentralRounded,
        CloseBackUnrounded,
        CloseBackRounded,
        NearCloseFrontUnrounded,
        NearCloseFrontRounded,
        NearCloseBackRounded,
        CloseMidFrontUnrounded,
        CloseMidFrontRounded,
        CloseMidCentralUnrounded,
        CloseMidCentralRounded,
        CloseMidBackUnrounded,
        CloseMidBackRounded,
        MidCentral,
        OpenMidFrontUnrounded,
        OpenMidFrontRounded,
        OpenMidCentralUnrounded,
        OpenMidCentralRounded,
        OpenMidBackUnrounded,
        OpenMidBackRounded,
        NearOpenFrontUnrounded,
        NearOpenCentral,
        OpenFrontUnrounded,
        OpenFrontRounded,
        OpenBackUnrounded,
        OpenBackRounded
    ];
}