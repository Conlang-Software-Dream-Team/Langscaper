using System.Collections.Immutable;

namespace Langscaper_Core.Phonology
{

    // From https://en.wikipedia.org/wiki/Table_of_vowels


    public enum Phoneme
    {
        // Consonant
        VoicedBilabialNasal,
        VoicedLabiodentalNasal,
        VoicedAlveolarNasal,
        VoicedRetroflexNasal,
        VoicedPalatalNasal,
        VoicedVelarNasal,
        VoicedUvularNasal,
        VoicelessBilabialPlosive,
        VoicedBilabialPlosive,
        VoicelessAlveolarPlosive,
        VoicedAlveolarPlosive,
        VoicelessRetroflexPlosive,
        VoicedRetroflexPlosive,
        VoicelessPalatalPlosive,
        VoicedPalatalPlosive,
        VoicelessVelarPlosive,
        VoicedVelarPlosive,
        VoicelessUvularPlosive,
        VoicedUvularPlosive,
        GlottalStop,
        VoicelessBilabialFricative,
        VoicedBilabialFricative,
        VoicelessLabiodentalFricative,
        VoicedLabiodentalFricative,
        VoicelessDentalFricative,
        VoicedDentalFricative,
        VoicelessAlveolarFricative,
        VoicedAlveolarFricative,
        VoicelessPostalveolarFricative,
        VoicedPostalveolarFricative,
        VoicelessRetroflexFricative,
        VoicedRetroflexFricative,
        VoicelessPalatalFricative,
        VoicedPalatalFricative,
        VoicelessVelarFricative,
        VoicedVelarFricative,
        VoicelessUvularFricative,
        VoicedUvularFricative,
        VoicelessPharyngealFricative,
        VoicedPharyngealFricative,
        VoicelessGlottalFricative,
        VoicedGlottalFricative,
        LabiodentalApproximant,
        AlveolarApproximant,
        RetroflexApproximant,
        PalatalApproximant,
        VelarApproximant,
        BilabialTrill,
        AlveolarTrill,
        UvularTrill,
        AlveolarTap,
        RetroflexTap,
        VoicelessAlveolarLateralFricative,
        VoicedAlveolarLateralFricative,
        AlveolarLateralApproximant,
        RetroflexLateralApproximant,
        PalatalLateralApproximant,
        VelarLateralApproximant,
        CloseFrontUnroundedVowel,
        CloseFrontRoundedVowel,
        CloseCentralUnroundedVowel,
        CloseCentralRoundedVowel,
        CloseBackUnroundedVowel,
        CloseBackRoundedVowel,
        NearCloseNearFrontUnroundedVowel,
        NearCloseNearFrontRoundedVowel,
        NearCloseNearBackRoundedVowel,
        CloseMidFrontUnroundedVowel,
        CloseMidFrontRoundedVowel,
        MidCentralVowel,
        OpenMidFrontUnroundedVowel,
        OpenMidFrontRoundedVowel,
        OpenMidBackUnroundedVowel,
        OpenMidBackRoundedVowel,
        NearOpenFrontUnroundedVowel,
        OpenFrontUnroundedVowel,
        OpenBackUnroundedVowel,
        OpenBackRoundedVowel,

        //Vowels

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
        OpenBackRounded,
        VoicedAlveolarLateralApproximant,
        VoicedRetroflexLateralApproximant,
        VoicedLabioDentalApproximant,
        VoicedAlveolarApproximant,
        VoicedRetroflexApproximant,
        VoicedPalatalApproximant,
        VoicedVelarApproximant,
        VoicedBilabialTrill,
        VoicedAlveolarTrill,
        VoicedUvularTrill,
        VoicedAlveolarTap,
        VoicedRetroflexTap,
        VoicedPalatalLateralApproximant,
        VoicedVelarLateralApproximant,
        VoicedPostAlveolarSibilantFricative,
        VoicelessPostAlveolarSibilantFricative,
        VoicedLabioDentalFricative,
        VoicelessLabioDentalFricative,
        VoicelessGlottalPlosive,
        VoicedLabioDentalNasal,
        Voicedlabiodentalflap,
        VoicedLabioVelarApproximant,
    }

    public static class PhonemeCategories
    {
        // Height (rows)
        public static ImmutableList<Phoneme> close =
         [
            Phoneme.CloseFrontUnrounded,
            Phoneme.CloseFrontRounded,
            Phoneme.CloseCentralUnrounded,
            Phoneme.CloseCentralRounded,
            Phoneme.CloseBackUnrounded,
            Phoneme.CloseBackRounded,
         ];
        public static ImmutableList<Phoneme> nearClose =
        [
                Phoneme.NearCloseFrontUnrounded,
            Phoneme.NearCloseFrontRounded,
            Phoneme.NearCloseBackRounded,
        ];
        public static ImmutableList<Phoneme> closeMid =
        [
            Phoneme.CloseMidFrontUnrounded,
        Phoneme.CloseMidFrontRounded,
        Phoneme.CloseMidCentralUnrounded,
        Phoneme.CloseMidCentralRounded,
        Phoneme.CloseMidBackUnrounded,
        Phoneme.CloseMidBackRounded
         ];
        public static ImmutableList<Phoneme> mid = [Phoneme.MidCentral];
        public static ImmutableList<Phoneme> OpenMid =
        [
                Phoneme.OpenMidFrontUnrounded,
            Phoneme.OpenMidFrontRounded,
            Phoneme.OpenMidCentralUnrounded,
            Phoneme.OpenMidCentralRounded,
            Phoneme.OpenMidBackUnrounded,
            Phoneme.OpenMidBackRounded
        ];
        public static ImmutableList<Phoneme> nearOpen =
        [
                Phoneme.NearOpenFrontUnrounded,
            Phoneme.NearOpenCentral,
    ];

        public static ImmutableList<Phoneme> Open =
        [
                Phoneme.OpenFrontUnrounded,
            Phoneme.OpenFrontRounded,
            Phoneme.OpenBackUnrounded,
            Phoneme.OpenBackRounded
        ];

        public static ImmutableList<Phoneme> Vowels =
            close.Concat(nearClose)
                 .Concat(closeMid)
                 .Concat(mid)
                 .Concat(OpenMid)
                 .Concat(nearOpen)
                 .Concat(Open)
                 .ToImmutableList();

        //Backness (columns)
        public static ImmutableList<Phoneme> front =
        [
                Phoneme.CloseFrontUnrounded,
            Phoneme.CloseFrontRounded,

            Phoneme.NearCloseFrontUnrounded,
            Phoneme.NearCloseFrontRounded,

            Phoneme.CloseMidFrontUnrounded,
            Phoneme.CloseMidFrontRounded,

            Phoneme.OpenMidFrontUnrounded,
            Phoneme.OpenMidFrontRounded,

            Phoneme.NearOpenFrontUnrounded,

            Phoneme.OpenFrontUnrounded,
            Phoneme.OpenFrontRounded
        ];

        public static ImmutableList<Phoneme> Central =
        [
            Phoneme.CloseCentralUnrounded,
            Phoneme.CloseCentralRounded,

            Phoneme.CloseMidCentralUnrounded,
            Phoneme.CloseMidCentralRounded,

            Phoneme.MidCentral,

            Phoneme.OpenMidCentralUnrounded,
            Phoneme.OpenMidCentralRounded,

            Phoneme.NearOpenCentral,
        ];
        public static ImmutableList<Phoneme> Back =
        [
            Phoneme.CloseBackUnrounded,
            Phoneme.CloseBackRounded,

            Phoneme.NearCloseBackRounded,

            Phoneme.CloseMidBackUnrounded,
            Phoneme.CloseMidBackRounded,

            Phoneme.OpenMidBackUnrounded,
            Phoneme.OpenMidBackRounded,

            Phoneme.OpenBackUnrounded,
            Phoneme.OpenBackRounded
        ];

        // Roundness

        public static ImmutableList<Phoneme> Rounded =
        [
            Phoneme.CloseFrontRounded,
            Phoneme.CloseCentralRounded,
            Phoneme.CloseBackRounded,

            Phoneme.NearCloseFrontRounded,

            Phoneme.CloseMidFrontRounded,
            Phoneme.CloseMidCentralRounded,
            Phoneme.CloseMidBackRounded,

            Phoneme.OpenMidFrontRounded,
            Phoneme.OpenMidCentralRounded,

            Phoneme.OpenMidBackRounded,

            Phoneme.NearOpenFrontUnrounded,

            Phoneme.OpenFrontRounded,
            Phoneme.OpenBackRounded

        ];
        public static ImmutableList<Phoneme> unrounded =
        [
            Phoneme.CloseFrontUnrounded,
            Phoneme.CloseCentralUnrounded,
            Phoneme.CloseBackUnrounded,

            Phoneme.NearCloseFrontUnrounded,

            Phoneme.CloseMidFrontUnrounded,
            Phoneme.CloseMidCentralUnrounded,
            Phoneme.CloseMidBackUnrounded,

            Phoneme.OpenMidFrontUnrounded,
            Phoneme.OpenMidCentralUnrounded,
            Phoneme.OpenMidBackUnrounded,

            Phoneme.NearOpenFrontUnrounded,

            Phoneme.OpenFrontUnrounded,
            Phoneme.OpenBackUnrounded
        ];


        #region CONSONANT
        #region definitions

        #endregion

        // Place of articulation

        public static ImmutableList<Phoneme> Bilabial =
        [
            Phoneme.VoicelessBilabialPlosive,
            Phoneme.VoicedBilabialPlosive,

            Phoneme.VoicedBilabialNasal,

            Phoneme.VoicelessBilabialFricative,
            Phoneme.VoicedBilabialFricative,
            Phoneme.VoicedBilabialTrill

        ];

        public static ImmutableList<Phoneme> Labiodental =
        [


            Phoneme.VoicelessLabioDentalFricative,
            Phoneme.VoicedLabioDentalFricative,

            Phoneme.VoicedLabioDentalApproximant
        ];

        public static ImmutableList<Phoneme> Dental =
        [
            Phoneme.VoicelessDentalFricative,
            Phoneme.VoicedDentalFricative,

        ];

        public static ImmutableList<Phoneme> Alveolar =
        [
            Phoneme.VoicelessAlveolarPlosive,
            Phoneme.VoicedAlveolarPlosive,

            Phoneme.VoicedAlveolarNasal,

            Phoneme.VoicelessAlveolarFricative,
            Phoneme.VoicedAlveolarFricative,

            Phoneme.VoicedAlveolarApproximant,
            Phoneme.VoicedAlveolarTrill,
            Phoneme.VoicedAlveolarTap,

            Phoneme.VoicelessAlveolarLateralFricative,
            Phoneme.VoicedAlveolarLateralFricative,
            Phoneme.VoicedAlveolarLateralApproximant,
        ];

        public static ImmutableList<Phoneme> PostAlveolar =
        [
            Phoneme.VoicelessPostAlveolarSibilantFricative,
            Phoneme.VoicedPostAlveolarSibilantFricative
        ];

        public static ImmutableList<Phoneme> Retroflex =
        [
            Phoneme.VoicelessRetroflexPlosive,
            Phoneme.VoicedRetroflexPlosive,

            Phoneme.VoicelessRetroflexFricative,
            Phoneme.VoicedRetroflexFricative,

            Phoneme.VoicedRetroflexApproximant,
            Phoneme.VoicedRetroflexTap,
            Phoneme.VoicedRetroflexLateralApproximant,

            Phoneme.VoicedRetroflexNasal
        ];

        public static ImmutableList<Phoneme> Palatal =
        [
            Phoneme.VoicedPalatalNasal,

            Phoneme.VoicelessPalatalPlosive,
            Phoneme.VoicedPalatalPlosive,

            Phoneme.VoicelessPalatalFricative,
            Phoneme.VoicedPalatalFricative,

            Phoneme.VoicedPalatalApproximant,
            Phoneme.VoicedPalatalLateralApproximant
        ];

        public static ImmutableList<Phoneme> Velar =
        [
            Phoneme.VoicelessVelarPlosive,
            Phoneme.VoicedVelarPlosive,

            Phoneme.VoicedVelarNasal,

            Phoneme.VoicelessVelarFricative,
            Phoneme.VoicedVelarFricative,

            Phoneme.VoicedVelarApproximant,
            Phoneme.VoicedVelarLateralApproximant
        ];

        public static ImmutableList<Phoneme> Uvular =
        [
            Phoneme.VoicelessUvularPlosive,
            Phoneme.VoicedUvularPlosive,

            Phoneme.VoicedUvularNasal,

            Phoneme.VoicelessUvularFricative,
            Phoneme.VoicedUvularFricative,

            Phoneme.VoicedUvularTrill,
        ];

        public static ImmutableList<Phoneme> Pharyngeal =
        [
            Phoneme.VoicelessPharyngealFricative,
            Phoneme.VoicedPharyngealFricative
        ];

        public static ImmutableList<Phoneme> Glottal =
        [
            Phoneme.VoicelessGlottalPlosive,
            Phoneme.VoicelessGlottalFricative,
            Phoneme.VoicedGlottalFricative
        ];

        // Mechanism
        public static ImmutableList<Phoneme> Pulmonics =
            Bilabial.Concat(Labiodental)
                    .Concat(Dental)
                    .Concat(Alveolar)
                    .Concat(PostAlveolar)
                    .Concat(Retroflex)
                    .Concat(Palatal)
                    .Concat(Velar)
                    .Concat(Uvular)
                    .Concat(Pharyngeal)
                    .Concat(Glottal)
                    .ToImmutableList();


        // Manner of articulation
        public static ImmutableList<Phoneme> Plosive = [
            Phoneme.VoicelessBilabialPlosive,
            Phoneme.VoicedBilabialPlosive,

            Phoneme.VoicelessAlveolarPlosive,
            Phoneme.VoicedAlveolarPlosive,

            Phoneme.VoicelessRetroflexPlosive,
            Phoneme.VoicedRetroflexPlosive,

            Phoneme.VoicelessPalatalPlosive,
            Phoneme.VoicedPalatalPlosive,

            Phoneme.VoicelessVelarPlosive,
            Phoneme.VoicedVelarPlosive,

            Phoneme.VoicelessUvularPlosive,
            Phoneme.VoicedUvularPlosive,

            Phoneme.VoicelessGlottalPlosive];

        public static ImmutableList<Phoneme> Nasals =
        [
            Phoneme.VoicedBilabialNasal,
            Phoneme.VoicedLabioDentalNasal,
            Phoneme.VoicedPalatalNasal,
            Phoneme.VoicedAlveolarNasal,
            Phoneme.VoicedVelarNasal,
            Phoneme.VoicedUvularNasal,
            Phoneme.VoicedRetroflexNasal

        ];
        public static ImmutableList<Phoneme> Trill =
        [
            Phoneme.VoicedBilabialTrill,
            Phoneme.VoicedAlveolarTrill,
            Phoneme.VoicedUvularTrill
        ];
        public static ImmutableList<Phoneme> TapOrFlap =
        [
            Phoneme.Voicedlabiodentalflap,
            Phoneme.VoicedAlveolarTap,
            Phoneme.VoicedRetroflexTap,
        ];
        public static ImmutableList<Phoneme> Fricative =
        [
            Phoneme.VoicelessBilabialFricative,
            Phoneme.VoicedBilabialFricative,

            Phoneme.VoicelessLabioDentalFricative,
            Phoneme.VoicedLabioDentalFricative,

            Phoneme.VoicelessDentalFricative,
            Phoneme.VoicedDentalFricative,

            Phoneme.VoicelessAlveolarFricative,
            Phoneme.VoicedAlveolarFricative,

            Phoneme.VoicelessPostAlveolarSibilantFricative,
            Phoneme.VoicedPostAlveolarSibilantFricative,

            Phoneme.VoicelessRetroflexFricative,
            Phoneme.VoicedRetroflexFricative,

            Phoneme.VoicelessPalatalFricative,
            Phoneme.VoicedPalatalFricative,

            Phoneme.VoicelessVelarFricative,
            Phoneme.VoicedVelarFricative,

            Phoneme.VoicelessUvularFricative,
            Phoneme.VoicedUvularFricative,

            Phoneme.VoicelessPharyngealFricative,
            Phoneme.VoicedPharyngealFricative,

            Phoneme.VoicelessGlottalFricative,
            Phoneme.VoicedGlottalFricative,
        ];

        public static ImmutableList<Phoneme> LateralFricative =
        [
            Phoneme.VoicelessAlveolarLateralFricative,
            Phoneme.VoicedAlveolarLateralFricative
        ];
        public static ImmutableList<Phoneme> Approximant =
        [
            Phoneme.VoicedAlveolarApproximant,
            Phoneme.VoicedLabioDentalApproximant,
            Phoneme.VoicedRetroflexApproximant,
            Phoneme.VoicedPalatalApproximant,
            Phoneme.VoicedVelarApproximant,
        ];
        public static ImmutableList<Phoneme> LateralApproximant =
        [
            Phoneme.VoicedAlveolarLateralApproximant,
            Phoneme.VoicedRetroflexLateralApproximant,
            Phoneme.VoicedPalatalLateralApproximant,
            Phoneme.VoicedVelarLateralApproximant
        ];


        #endregion

        // Categories
        public static ImmutableList<Phoneme> Consonants = Pulmonics.ToImmutableList();
        public static ImmutableList<Phoneme> Liquids =
        [
            Phoneme.VoicedAlveolarLateralApproximant,
            Phoneme.VoicedRetroflexLateralApproximant,
            Phoneme.VoicedPalatalLateralApproximant,
            Phoneme.VoicedVelarLateralApproximant,
            Phoneme.VoicedAlveolarTap,
            Phoneme.VoicedRetroflexTap,
            Phoneme.VoicedAlveolarTrill,
            Phoneme.VoicedUvularTrill,
        ];
        public static ImmutableList<Phoneme> Glides = [Phoneme.VoicedPalatalApproximant, Phoneme.VoicedLabioVelarApproximant];
        public static ImmutableList<Phoneme> Sonorants = Vowels.Concat(Nasals).Concat(Liquids).Concat(Glides).ToImmutableList();
    }

}
