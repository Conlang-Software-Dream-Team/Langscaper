using System.Collections.Immutable;
using System.Reflection.Metadata;

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

        public static ImmutableList<Phonem> vowels =
            close.Concat(nearClose)
                 .Concat(closeMid)
                 .Concat(mid)
                 .Concat(OpenMid)
                 .Concat(nearOpen)
                 .Concat(Open)
                 .ToImmutableList();

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
        #region definitions
        // Nasals
        public static Phonem VoicelessBilabialNasalStop = new("m̥", "VoicelessBilabialNasalStop", 100);
        public static Phonem VoicedBilabialNasal = new("m", "VoicedBilabialNasal", 100);
        public static Phonem VoicelessLabioDentalNasalStop = new("ɱ̊", "VoicelessLabioDentalNasalStop", 100);
        public static Phonem VoicedLabioDentalNasal = new("ɱ", "VoicedLabioDentalNasal", 100);
        public static Phonem VoicelessAlveolarNasalStop = new("n̥", "VoicelessAlveolarNasalStop", 100);
        public static Phonem VoicedAlveolarNasal = new("n", "VoicedAlveolarNasal", 100);
        public static Phonem VoicedRetroflexNasal = new("ɳ", "VoicedRetroflexNasal", 100);
        public static Phonem VoicedPalatalNasal = new("ɲ", "VoicedPalatalNasal", 100);
        public static Phonem VoicelessRetroflexNasalStop = new("ɲ̊", "VoicelessRetroflexNasalStop", 100);
        public static Phonem VoicedVelarNasal = new("ŋ", "VoicedVelarNasal", 100);
        public static Phonem VoicelessVelarNasalStop = new("ŋ̊", "VoicelessVelarNasalStop", 100);
        public static Phonem VoicedUvularNasal = new("ɴ", "VoicedUvularNasal", 100);

        // Plosives
        public static Phonem VoicelessBilabialPlosive = new("p", "VoicelessBilabialPlosive", 100);
        public static Phonem VoicedBilabialPlosive = new("b", "VoicedBilabialPlosive", 100);
        public static Phonem VoicelessLabioDentalPlosive = new("p̪", "VoicelessLabioDentalPlosive", 100);
        public static Phonem VoicedLabioDentalPlosive = new("b̪", "VoicedLabioDentalPlosive", 100);
        public static Phonem VoicelessAlveolarPlosive = new("t", "VoicelessAlveolarPlosive", 100);
        public static Phonem VoicedAlveolarPlosive = new("d", "VoicedAlveolarPlosive", 100);
        public static Phonem VoicelessRetroflexPlosive = new("ʈ", "VoicelessRetroflexPlosive", 100);
        public static Phonem VoicedRetroflexPlosive = new("ɖ", "VoicedRetroflexPlosive", 100);
        public static Phonem VoicelessPalatalPlosive = new("c", "VoicelessPalatalPlosive", 100);
        public static Phonem VoicedPalatalPlosive = new("ɟ", "VoicedPalatalPlosive", 100);
        public static Phonem VoicelessVelarPlosive = new("k", "VoicelessVelarPlosive", 100);
        public static Phonem VoicedVelarPlosive = new("ɡ", "VoicedVelarPlosive", 100);
        public static Phonem VoicelessUvularPlosive = new("q", "VoicelessUvularPlosive", 100);
        public static Phonem VoicedUvularPlosive = new("ɢ", "VoicedUvularPlosive", 100);
        public static Phonem VoicelessGlottalPlosive = new("ʔ", "VoicelessGlottalPlosive", 100);

        // Affricates
        public static Phonem VoicelessAlveolarSibilantAffricate = new("ts", "VoicelessAlveolarSibilantAffricate", 100);
        public static Phonem VoicedAlveolarSibilantAffricate = new("dz", "VoicedAlveolarSibilantAffricate", 100);
        public static Phonem VoicelessPostalveolarSibilantAffricate = new("tʃ", "VoicelessPostalveolarSibilantAffricate", 100);
        public static Phonem VoicedPostalveolarSibilantAffricate = new("dʒ", "VoicedPostalveolarSibilantAffricate", 100);
        public static Phonem VoicelessPalatalSibilantAffricate = new("cç", "VoicelessPalatalSibilantAffricate", 100);
        public static Phonem VoicedPalatalSibilantAffricate = new("ɟʝ", "VoicedPalatalSibilantAffricate", 100);

        // Fricatives
        public static Phonem VoicelessBilabialFricative = new("ɸ", "VoicelessBilabialFricative", 100);
        public static Phonem VoicedBilabialFricative = new("β", "VoicedBilabialFricative", 100);
        public static Phonem VoicelessLabioDentalFricative = new("f", "VoicedBilabialFricative", 100);
        public static Phonem VoicedLabioDentalFricative = new("v", "VoicedLabioDentalFricative", 100);
        public static Phonem VoicelessDentalFricative = new("θ", "VoicelessDentalFricative", 100);
        public static Phonem VoicedDentalFricative = new("ð", "VoicedDentalFricative", 100);
        public static Phonem VoicelessAlveolarFricative = new("s", "VoicelessAlveolarFricative", 100);
        public static Phonem VoicedAlveolarFricative = new("z", "VoicedAlveolarFricative", 100);
        public static Phonem VoicelessPostAlveolarSibilantFricative = new("ʃ", "VoicelessPostAlveolarSibilantFricative", 100);
        public static Phonem VoicedPostAlveolarSibilantFricative = new("ʒ", "VoicedPostAlveolarSibilantFricative", 100);
        public static Phonem VoicelessRetroflexFricative = new("ʂ", "VoicelessRetroflexFricative", 100);
        public static Phonem VoicedRetroflexFricative = new("ʐ", "VoicedRetroflexFricative", 100);
        public static Phonem VoicelessPalatalFricative = new("ç", "VoicelessPalatalFricative", 100);
        public static Phonem VoicedPalatalFricative = new("ʝ", "VoicedPalatalFricative", 100);
        public static Phonem VoicelessVelarFricative = new("x", "VoicelessVelarFricative", 100);
        public static Phonem VoicedVelarFricative = new("ɣ", "VoicedVelarFricative", 100);
        public static Phonem VoicelessUvularFricative = new("χ", "VoicelessUvularFricative", 100);
        public static Phonem VoicedUvularFricative = new("ʁ", "VoicedUvularFricative", 100);
        public static Phonem VoicelessPharyngealFricative = new("ħ", "VoicelessPharyngealFricative", 100);
        public static Phonem VoicedPharyngealFricative = new("ʕ", "VoicedPharyngealFricative", 100);
        public static Phonem VoicelessGlottalFricative = new("h", "VoicelessGlottalFricative", 100);
        public static Phonem VoicedGlottalFricative = new("ɦ", "VoicedGlottalFricative", 100);

        // Approximants
        public static Phonem VoicedBilabialApproximant = new("β", "VoicedBilabialApproximant", 100);
        public static Phonem VoicedLabioDentalApproximant = new("ʋ", "VoicedLabioDentalApproximant", 100);
        public static Phonem VoicedAlveolarApproximant = new("ɹ", "VoicedAlveolarApproximant", 100);
        public static Phonem VoicedRetroflexApproximant = new("ɻ", "VoicedRetroflexApproximant", 100);
        public static Phonem VoicedPalatalApproximant = new("j", "VoicedPalatalApproximant", 100);
        public static Phonem VoicedVelarApproximant = new("ɰ", "VoicedVelarApproximant", 100);
        public static Phonem VoicedUvularApproximant = new("ʁ̞", "VoicedUvularApproximant", 100);
        public static Phonem VoicedLabioVelarApproximant = new("w", "VoicedLabioVelarApproximant", 100);

        // Trills
        public static Phonem VoicedBilabialTrill = new("ʙ", "VoicedBilabialTrill", 100);
        public static Phonem VoicedAlveolarTrill = new("r", "VoicedAlveolarTrill", 100);
        public static Phonem VoicedRetroflexTrill = new("ɽr", "VoicedRetroflexTrill", 100);
        public static Phonem VoicedUvularTrill = new("ʀ", "VoicedUvularTrill", 100);

        // Taps and Flaps
        public static Phonem VoicedAlveolarTap = new("ɾ", "VoicedAlveolarTap", 100);
        public static Phonem VoicedRetroflexTap = new("ɽ", "VoicedRetroflexTap", 100);
        public static Phonem Voicedlabiodentalflap = new("ⱱ", "Voiced labiodental flap", 100);
        // Lateral Approximants
        public static Phonem VoicedAlveolarLateralApproximant = new("l", "VoicedAlveolarLateralApproximant", 100);
        public static Phonem VoicedRetroflexLateralApproximant = new("ɭ", "VoicedRetroflexLateralApproximant", 100);
        public static Phonem VoicedPalatalLateralApproximant = new("ʎ", "VoicedPalatalLateralApproximant", 100);
        public static Phonem VoicedVelarLateralApproximant = new("ʟ", "VoicedVelarLateralApproximant", 100);
        public static Phonem VoicedPalatalLateralApproximantWithDiacritic = new("ʎ", "VoicedPalatalLateralApproximantWithDiacritic", 100);

        // Lateral Fricatives
        public static Phonem VoicelessAlveolarLateralFricative = new("ɬ", "VoicelessAlveolarLateralFricative", 100);
        public static Phonem VoicedAlveolarLateralFricative = new("ɮ", "VoicedAlveolarLateralFricative", 100);

        // Lateral Affricates
        public static Phonem VoicelessAlveolarLateralAffricate = new("tɬ", "VoicelessAlveolarLateralAffricate", 100);
        public static Phonem VoicedAlveolarLateralAffricate = new("dɮ", "VoicedAlveolarLateralAffricate", 100);

        // Lateral Taps and Flaps
        public static Phonem VoicedAlveolarLateralTap = new("ɺ", "VoicedAlveolarLateralTap", 100);


        // Clicks 
        public static Phonem VoicelessBilabialClick = new("ʘ", "VoicelessBilabialClick", 100);
        public static Phonem VoicelessDentalClick = new("ǀ", "VoicelessDentalClick", 100);
        public static Phonem VoicelessAlveolarClick = new("ǃ", "VoicelessAlveolarClick", 100);
        public static Phonem VoicelessPostalveolarClick = new("ǂ", "VoicelessPostalveolarClick", 100);
        public static Phonem VoicelessPalatalClick = new("ǁ", "VoicelessPalatalClick", 100);

        public static Phonem VoicedBilabialClick = new("ᶢʘ", "VoicedBilabialClick", 100);
        public static Phonem VoicedDentalClick = new("ᶢǀ", "VoicedDentalClick", 100);
        public static Phonem VoicedAlveolarClick = new("ᶢǃ", "VoicedAlveolarClick", 100);
        public static Phonem VoicedPostalveolarClick = new("ᶢǂ", "VoicedPostalveolarClick", 100);
        public static Phonem VoicedPalatalClick = new("ᶢǁ", "VoicedPalatalClick", 100);

        // Implosives
        public static Phonem VoicedBilabialImplosive = new("ɓ", "VoicedBilabialImplosive", 100);
        public static Phonem VoicedAlveolarImplosive = new("ɗ", "VoicedAlveolarImplosive", 100);
        public static Phonem VoicedRetroflexImplosive = new("ᶑ", "VoicedRetroflexImplosive", 100);
        public static Phonem VoicedPalatalImplosive = new("ʛ", "VoicedPalatalImplosive", 100);
        public static Phonem VoicedVelarImplosive = new("ɠ", "VoicedVelarImplosive", 100);
        public static Phonem VoicedUvularImplosive = new("ʛ", "VoicedUvularImplosive", 100);

        // Ejectives
        public static Phonem VoicelessBilabialEjective = new("pʼ", "VoicelessBilabialEjective", 100);
        public static Phonem VoicelessAlveolarEjective = new("tʼ", "VoicelessAlveolarEjective", 100);
        public static Phonem VoicelessVelarEjective = new("kʼ", "VoicelessVelarEjective", 100);
        public static Phonem VoicelessUvularEjective = new("qʼ", "VoicelessUvularEjective", 100);

        #endregion

        // Pulmonic Consonants

        public static ImmutableList<Phonem> Bilabial =
        [
            VoicelessBilabialPlosive,
            VoicedBilabialPlosive,

            VoicelessBilabialNasalStop,
            VoicedBilabialNasal,

            VoicelessBilabialFricative,
            VoicedBilabialFricative,
            VoicedBilabialApproximant,
            VoicedBilabialTrill,

            VoicelessBilabialClick,
            VoicedBilabialClick,



            VoicelessBilabialEjective
        ];

        public static ImmutableList<Phonem> Labiodental =
        [
            VoicelessLabioDentalPlosive,
            VoicedLabioDentalPlosive,

            VoicelessLabioDentalNasalStop,
            VoicedLabioDentalNasal,
            Voicedlabiodentalflap,

            VoicelessLabioDentalFricative,
            VoicedLabioDentalFricative,

            VoicedLabioDentalApproximant
        ];

        public static ImmutableList<Phonem> Dental =
        [
            VoicelessDentalFricative,
            VoicedDentalFricative,

            VoicelessDentalClick,
            VoicedDentalClick
        ];

        public static ImmutableList<Phonem> Alveolar =
        [
            VoicelessAlveolarPlosive,
            VoicedAlveolarPlosive,

            VoicedAlveolarNasal,

            VoicelessAlveolarFricative,
            VoicedAlveolarFricative,

            VoicedAlveolarApproximant,
            VoicedAlveolarTrill,
            VoicedAlveolarTap,

            VoicelessAlveolarLateralFricative,
            VoicedAlveolarLateralFricative,
            VoicedAlveolarLateralApproximant,
            VoicedAlveolarLateralTap
        ];

        public static ImmutableList<Phonem> PostAlveolar =
        [
            VoicelessPostAlveolarSibilantFricative,
            VoicedPostAlveolarSibilantFricative
        ];

        public static ImmutableList<Phonem> Retroflex =
        [
            VoicelessRetroflexPlosive,
            VoicedRetroflexPlosive,

            VoicelessRetroflexFricative,
            VoicedRetroflexFricative,

            VoicedRetroflexApproximant,
            VoicedRetroflexTrill,
            VoicedRetroflexTap,
            VoicedRetroflexLateralApproximant,

            VoicedRetroflexNasal
        ];

        public static ImmutableList<Phonem> Palatal =
        [
            VoicedPalatalNasal,

            VoicelessPalatalPlosive,
            VoicedPalatalPlosive,

            VoicelessPalatalFricative,
            VoicedPalatalFricative,

            VoicedPalatalApproximant,
            VoicedPalatalLateralApproximant
        ];

        public static ImmutableList<Phonem> Velar =
        [
            VoicelessVelarPlosive,
            VoicedVelarPlosive,

            VoicedVelarNasal,

            VoicelessVelarFricative,
            VoicedVelarFricative,

            VoicedVelarApproximant,
            VoicedVelarLateralApproximant
        ];

        public static ImmutableList<Phonem> Uvular =
        [
            VoicelessUvularPlosive,
            VoicedUvularPlosive,

            VoicedUvularNasal,

            VoicelessUvularFricative,
            VoicedUvularFricative,

            VoicedUvularTrill,
            VoicedUvularApproximant
        ];

        public static ImmutableList<Phonem> Pharyngeal =
        [
            VoicelessPharyngealFricative,
            VoicedPharyngealFricative
        ];

        public static ImmutableList<Phonem> Glottal =
        [
            VoicelessGlottalPlosive,
            VoicelessGlottalFricative,
            VoicedGlottalFricative
        ];

        public static ImmutableList<Phonem> Pulmonics =
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



        // Non-pulmonic Consonants
        // Non-pulmonic
        public static ImmutableList<Phonem> NonPulmonicClicks =
        [
            VoicelessBilabialClick,
            VoicedBilabialClick,
            VoicelessDentalClick,
            VoicedDentalClick,
            VoicelessAlveolarClick,
            VoicedAlveolarClick,
            VoicelessPostalveolarClick,
            VoicedPostalveolarClick,
            VoicelessPalatalClick
        ];

        public static ImmutableList<Phonem> NonPulmonicImplosives =
        [
            VoicedBilabialImplosive,
            VoicedAlveolarImplosive,
            VoicedRetroflexImplosive,
            VoicedPalatalImplosive,
            VoicedVelarImplosive,
            VoicedUvularImplosive
        ];

        public static ImmutableList<Phonem> NonPulmonicEjectives =
        [
            VoicelessBilabialEjective,
            VoicelessAlveolarEjective,
            VoicelessVelarEjective,
            VoicelessUvularEjective
        ];

        public static ImmutableList<Phonem> NonPulmonics =
            NonPulmonicClicks.Concat(NonPulmonicImplosives)
                             .Concat(NonPulmonicEjectives)
                             .ToImmutableList();

        // Manners
        public static ImmutableList<Phonem> Plosive = [  VoicelessBilabialPlosive,
            VoicedBilabialPlosive,

            VoicelessLabioDentalPlosive,
            VoicedLabioDentalPlosive,

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

            VoicelessGlottalPlosive];
        public static ImmutableList<Phonem> Nasal =
        [
            VoicedBilabialNasal,
            VoicedLabioDentalNasal,
            VoicedPalatalNasal,
            VoicedAlveolarNasal,
            VoicedVelarNasal,
            VoicedUvularNasal,
            VoicedRetroflexNasal

        ];
        public static ImmutableList<Phonem> Trill =
        [
            VoicedBilabialTrill,
            VoicedAlveolarTrill,
            VoicedUvularTrill
        ];
        public static ImmutableList<Phonem> TapOrFlap =
        [
            Voicedlabiodentalflap,
            VoicedAlveolarTap,
            VoicedRetroflexTap,
        ];
        public static ImmutableList<Phonem> Fricative =
        [
              VoicelessBilabialFricative,
            VoicedBilabialFricative,

            VoicelessLabioDentalFricative,
            VoicedLabioDentalFricative,

            VoicelessDentalFricative,
            VoicedDentalFricative,

            VoicelessAlveolarFricative,
            VoicedAlveolarFricative,

            VoicelessPostAlveolarSibilantFricative,
            VoicedPostAlveolarSibilantFricative,

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
        ];

        public static ImmutableList<Phonem> LateralFricative =
        [
            VoicelessAlveolarLateralFricative,
            VoicedAlveolarLateralFricative
        ];
        public static ImmutableList<Phonem> Approximant =
        [
            VoicedBilabialApproximant,
            VoicedAlveolarApproximant,
            VoicedLabioDentalApproximant,
            VoicedRetroflexApproximant,
            VoicedPalatalApproximant,
            VoicedVelarApproximant,
        ];
        public static ImmutableList<Phonem> LateralApproximant =
        [
            VoicedAlveolarLateralApproximant,
            VoicedRetroflexLateralApproximant,
            VoicedPalatalLateralApproximant,
            VoicedVelarLateralApproximant
        ];

        public static ImmutableList<Phonem> Consonants = Pulmonics.Concat(NonPulmonics).ToImmutableList();

        #endregion
    }


    #region Vowels Categories

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

    #region Consonants Categories
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
        PharyngealOrEpiglottal,
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
        Click,
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
        NonPulmonic,
        Ejective,
        Implosive
    }

    public enum Sonorance
    {
        Sonorant,
        Obstruent,
        Liquid,
        Undefined
    }


    #endregion


}