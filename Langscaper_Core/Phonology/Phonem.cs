using System.Collections.Immutable;

namespace Phonology
{
    public readonly record struct Phonem(string ipa, string name, byte rarity) // rarity in the real world 0 to 125
    {
        // From https://en.wikipedia.org/wiki/Table_of_vowels
        // rarity from https://phoible.org/parameters
        #region VOWELS

        public static Phonem CloseFrontUnrounded = new("i", "CloseFrontUnrounded", 92);
        public static Phonem CloseFrontRounded = new("y", "CloseFrontRounded", 6);
        public static Phonem CloseCentralUnrounded = new("ɨ", "CloseCentralUnrounded", 16);
        public static Phonem CloseCentralRounded = new("ʉ", "CloseCentralRounded", 2);
        public static Phonem CloseBackUnrounded = new("ɯ", "CloseBackUnrounded", 6);
        public static Phonem CloseBackRounded = new("u", "CloseBackRounded", 88);

        public static Phonem NearCloseFrontUnrounded = new("ɪ", "NearCloseFrontUnrounded", 15);
        public static Phonem NearCloseFrontRounded = new("ʏ", "NearCloseFrontRounded", 1);
        public static Phonem NearCloseBackRounded = new("ʊ", "NearCloseBackRounded", 14);

        public static Phonem CloseMidFrontUnrounded = new("e", "CloseMidFrontUnrounded", 61);
        public static Phonem CloseMidFrontRounded = new("ø", "CloseMidFrontRounded", 3);
        public static Phonem CloseMidCentralUnrounded = new("ɘ", "CloseMidCentralUnrounded", 1);
        public static Phonem CloseMidCentralRounded = new("ɵ", "CloseMidCentralRounded", 1);
        public static Phonem CloseMidBackUnrounded = new("ɤ", "CloseMidBackUnrounded", 3);
        public static Phonem CloseMidBackRounded = new("o", "CloseMidBackRounded", 60);

        public static Phonem MidCentral = new("ə", "MidCentral", 22);

        public static Phonem OpenMidFrontUnrounded = new("ɛ", "OpenMidFrontUnrounded", 37);
        public static Phonem OpenMidFrontRounded = new("œ", "OpenMidFrontRounded", 3);
        public static Phonem OpenMidCentralUnrounded = new("ɜ", "OpenMidCentralUnrounded", 1);
        public static Phonem OpenMidCentralRounded = new("ɞ", "OpenMidCentralRounded", 0);
        public static Phonem OpenMidBackUnrounded = new("ʌ", "OpenMidBackUnrounded", 4);
        public static Phonem OpenMidBackRounded = new("ɔ", "OpenMidBackRounded", 35);

        public static Phonem NearOpenFrontUnrounded = new("æ", "NearOpenFrontUnrounded", 7);
        public static Phonem NearOpenCentral = new("ɐ", "NearOpenCentral", 2);

        public static Phonem OpenFrontUnrounded = new("a", "OpenFrontUnrounded", 86);
        public static Phonem OpenFrontRounded = new("ɶ", "OpenFrontRounded", 0);
        public static Phonem OpenBackUnrounded = new("ɑ", "OpenBackUnrounded", 7);
        public static Phonem OpenBackRounded = new("ɒ", "OpenBackRounded", 2);


        public static ImmutableList<Phonem> vowels =
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

        // Height (rows)
        public static ImmutableList<Phonem> close =
         [
            CloseFrontUnrounded,
            CloseFrontRounded,
            CloseCentralUnrounded,
            CloseCentralRounded,
            CloseBackUnrounded,
            CloseBackRounded,
         ];
        public static ImmutableList<Phonem> nearClose =
        [
            NearCloseFrontUnrounded,
            NearCloseFrontRounded,
            NearCloseBackRounded,
        ];
        public static ImmutableList<Phonem> closeMid =
        [
            CloseMidFrontUnrounded,
            CloseMidFrontRounded,
            CloseMidCentralUnrounded,
            CloseMidCentralRounded,
            CloseMidBackUnrounded,
            CloseMidBackRounded
         ];
        public static ImmutableList<Phonem> mid = [MidCentral];
        public static ImmutableList<Phonem> OpenMid =
        [
            OpenMidFrontUnrounded,
            OpenMidFrontRounded,
            OpenMidCentralUnrounded,
            OpenMidCentralRounded,
            OpenMidBackUnrounded,
            OpenMidBackRounded
        ];
        public static ImmutableList<Phonem> nearOpen =
        [
             NearOpenFrontUnrounded,
             NearOpenCentral,
        ];
        public static ImmutableList<Phonem> Open =
        [
            OpenFrontUnrounded,
            OpenFrontRounded,
            OpenBackUnrounded,
            OpenBackRounded
        ];

        //Backness (columns)
        public static ImmutableList<Phonem> front =
        [
            CloseFrontUnrounded,
            CloseFrontRounded,

            NearCloseFrontUnrounded,
            NearCloseFrontRounded,

            CloseMidFrontUnrounded,
            CloseMidFrontRounded,

            OpenMidFrontUnrounded,
            OpenMidFrontRounded,

            NearOpenFrontUnrounded,

            OpenFrontUnrounded,
            OpenFrontRounded
        ];
        public static ImmutableList<Phonem> Central =
        [
            CloseCentralUnrounded,
            CloseCentralRounded,

            CloseMidCentralUnrounded,
            CloseMidCentralRounded,

            MidCentral,

            OpenMidCentralUnrounded,
            OpenMidCentralRounded,

            NearOpenCentral,
        ];
        public static ImmutableList<Phonem> Back =
        [
            CloseBackUnrounded,
            CloseBackRounded,

            NearCloseBackRounded,

            CloseMidBackUnrounded,
            CloseMidBackRounded,

            OpenMidBackUnrounded,
            OpenMidBackRounded,

            OpenBackUnrounded,
            OpenBackRounded
        ];

        // Roundness

        public static ImmutableList<Phonem> Rounded =
        [
            CloseFrontRounded,
            CloseCentralRounded,
            CloseBackRounded,

            NearCloseFrontRounded,

            CloseMidFrontRounded,
            CloseMidCentralRounded,
            CloseMidBackRounded,

            OpenMidFrontRounded,
            OpenMidCentralRounded,

            OpenMidBackRounded,

            NearOpenFrontUnrounded,

            OpenFrontRounded,
            OpenBackRounded

        ];
        public static ImmutableList<Phonem> unrounded =
        [
            CloseFrontUnrounded,
            CloseCentralUnrounded,
            CloseBackUnrounded,

            NearCloseFrontUnrounded,

            CloseMidFrontUnrounded,
            CloseMidCentralUnrounded,
            CloseMidBackUnrounded,

            OpenMidFrontUnrounded,
            OpenMidCentralUnrounded,
            OpenMidBackUnrounded,

            NearOpenFrontUnrounded,

            OpenFrontUnrounded,
            OpenBackUnrounded
        ];

        #endregion

        #region CONSONANT
        #endregion
    }


    #region Vowels

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



    #endregion
}