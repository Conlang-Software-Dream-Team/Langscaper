namespace CSP_Core.Phonology
{
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

    public readonly record struct Consonant(string Symbol, PlaceOfArticulation PlaceOfArticulation, MannerOfArticulation MannerOfArticulation, Voicing Voicing, Mechanism Mechanism, Sonorance Sonorance)

    {
        // Nasals
        public static Consonant VoicelessBilabialNasalStop = new("m̥", PlaceOfArticulation.Bilabial, MannerOfArticulation.Nasal, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedBilabialNasal = new("m", PlaceOfArticulation.Bilabial, MannerOfArticulation.Nasal, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicelessLabioDentalNasalStop = new("ɱ̊", PlaceOfArticulation.LabioDental, MannerOfArticulation.Nasal, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedLabioDentalNasal = new("ɱ", PlaceOfArticulation.LabioDental, MannerOfArticulation.Nasal, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicelessAlveolarNasalStop = new("n̥", PlaceOfArticulation.Alveolar, MannerOfArticulation.Nasal, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedAlveolarNasal = new("n", PlaceOfArticulation.Alveolar, MannerOfArticulation.Nasal, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedAlveolarNasalRetroflex = new("ɳ", PlaceOfArticulation.Retroflex, MannerOfArticulation.Nasal, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicelessRetroflexNasalStop = new("ɲ̊", PlaceOfArticulation.Palatal, MannerOfArticulation.Nasal, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedVelarNasal = new("ŋ", PlaceOfArticulation.Velar, MannerOfArticulation.Nasal, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicelessVelarNasalStop = new("ŋ̊", PlaceOfArticulation.Velar, MannerOfArticulation.Nasal, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedUvularNasal = new("ɴ", PlaceOfArticulation.Uvular, MannerOfArticulation.Nasal, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);

        // Plosives
        public static Consonant VoicelessBilabialPlosive = new("p", PlaceOfArticulation.Bilabial, MannerOfArticulation.Plosive, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedBilabialPlosive = new("b", PlaceOfArticulation.Bilabial, MannerOfArticulation.Plosive, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessLabioDentalPlosive = new("p̪", PlaceOfArticulation.LabioDental, MannerOfArticulation.Plosive, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedLabioDentalPlosive = new("b̪", PlaceOfArticulation.LabioDental, MannerOfArticulation.Plosive, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessAlveolarPlosive = new("t", PlaceOfArticulation.Alveolar, MannerOfArticulation.Plosive, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedAlveolarPlosive = new("d", PlaceOfArticulation.Alveolar, MannerOfArticulation.Plosive, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessRetroflexPlosive = new("ʈ", PlaceOfArticulation.Retroflex, MannerOfArticulation.Plosive, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedRetroflexPlosive = new("ɖ", PlaceOfArticulation.Retroflex, MannerOfArticulation.Plosive, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessPalatalPlosive = new("c", PlaceOfArticulation.Palatal, MannerOfArticulation.Plosive, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedPalatalPlosive = new("ɟ", PlaceOfArticulation.Palatal, MannerOfArticulation.Plosive, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessVelarPlosive = new("k", PlaceOfArticulation.Velar, MannerOfArticulation.Plosive, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedVelarPlosive = new("ɡ", PlaceOfArticulation.Velar, MannerOfArticulation.Plosive, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessUvularPlosive = new("q", PlaceOfArticulation.Uvular, MannerOfArticulation.Plosive, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedUvularPlosive = new("ɢ", PlaceOfArticulation.Uvular, MannerOfArticulation.Plosive, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessGlottalPlosive = new("ʔ", PlaceOfArticulation.Glottal, MannerOfArticulation.Plosive, Voicing.Undefined, Mechanism.Pulmonic, Sonorance.Obstruent);

        // Affricates
        public static Consonant VoicelessAlveolarSibilantAffricate = new("ts", PlaceOfArticulation.Alveolar, MannerOfArticulation.SibilantAffricate, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedAlveolarSibilantAffricate = new("dz", PlaceOfArticulation.Alveolar, MannerOfArticulation.SibilantAffricate, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessPostalveolarSibilantAffricate = new("tʃ", PlaceOfArticulation.PostAlveolar, MannerOfArticulation.SibilantAffricate, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedPostalveolarSibilantAffricate = new("dʒ", PlaceOfArticulation.PostAlveolar, MannerOfArticulation.SibilantAffricate, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessPalatalSibilantAffricate = new("cç", PlaceOfArticulation.Palatal, MannerOfArticulation.SibilantAffricate, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedPalatalSibilantAffricate = new("ɟʝ", PlaceOfArticulation.Palatal, MannerOfArticulation.SibilantAffricate, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);

        // Fricatives
        public static Consonant VoicelessBilabialFricative = new("ɸ", PlaceOfArticulation.Bilabial, MannerOfArticulation.SibilantFricative, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedBilabialFricative = new("β", PlaceOfArticulation.Bilabial, MannerOfArticulation.SibilantFricative, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessLabioDentalFricative = new("f", PlaceOfArticulation.LabioDental, MannerOfArticulation.SibilantFricative, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedLabioDentalFricative = new("v", PlaceOfArticulation.LabioDental, MannerOfArticulation.SibilantFricative, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessDentalFricative = new("θ", PlaceOfArticulation.Dental, MannerOfArticulation.SibilantFricative, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedDentalFricative = new("ð", PlaceOfArticulation.Dental, MannerOfArticulation.SibilantFricative, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessAlveolarFricative = new("s", PlaceOfArticulation.Alveolar, MannerOfArticulation.SibilantFricative, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedAlveolarFricative = new("z", PlaceOfArticulation.Alveolar, MannerOfArticulation.SibilantFricative, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessPostAlveolarSibilantFricative = new("ʃ", PlaceOfArticulation.PostAlveolar, MannerOfArticulation.SibilantFricative, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedPostAlveolarSibilantFricative = new("ʒ", PlaceOfArticulation.PostAlveolar, MannerOfArticulation.SibilantFricative, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessRetroflexFricative = new("ʂ", PlaceOfArticulation.Retroflex, MannerOfArticulation.SibilantFricative, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedRetroflexFricative = new("ʐ", PlaceOfArticulation.Retroflex, MannerOfArticulation.SibilantFricative, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessPalatalFricative = new("ç", PlaceOfArticulation.Palatal, MannerOfArticulation.SibilantFricative, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedPalatalFricative = new("ʝ", PlaceOfArticulation.Palatal, MannerOfArticulation.SibilantFricative, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessVelarFricative = new("x", PlaceOfArticulation.Velar, MannerOfArticulation.SibilantFricative, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedVelarFricative = new("ɣ", PlaceOfArticulation.Velar, MannerOfArticulation.SibilantFricative, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessUvularFricative = new("χ", PlaceOfArticulation.Uvular, MannerOfArticulation.SibilantFricative, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedUvularFricative = new("ʁ", PlaceOfArticulation.Uvular, MannerOfArticulation.SibilantFricative, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessPharyngealFricative = new("ħ", PlaceOfArticulation.PharyngealOrEpiglottal, MannerOfArticulation.NonSibilantFricative, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedPharyngealFricative = new("ʕ", PlaceOfArticulation.PharyngealOrEpiglottal, MannerOfArticulation.NonSibilantFricative, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessGlottalFricative = new("h", PlaceOfArticulation.Glottal, MannerOfArticulation.NonSibilantFricative, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedGlottalFricative = new("ɦ", PlaceOfArticulation.Glottal, MannerOfArticulation.NonSibilantFricative, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);

        // Approximants
        public static Consonant VoicedBilabialApproximant = new("β", PlaceOfArticulation.Bilabial, MannerOfArticulation.Approximant, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedLabioDentalApproximant = new("ʋ", PlaceOfArticulation.LabioDental, MannerOfArticulation.Approximant, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedAlveolarApproximant = new("ɹ", PlaceOfArticulation.Alveolar, MannerOfArticulation.Approximant, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedRetroflexApproximant = new("ɻ", PlaceOfArticulation.Retroflex, MannerOfArticulation.Approximant, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedPalatalApproximant = new("j", PlaceOfArticulation.Palatal, MannerOfArticulation.Approximant, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedVelarApproximant = new("ɰ", PlaceOfArticulation.Velar, MannerOfArticulation.Approximant, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedUvularApproximant = new("ʁ̞", PlaceOfArticulation.Uvular, MannerOfArticulation.Approximant, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedLabioVelarApproximant = new("w", PlaceOfArticulation.Velar, MannerOfArticulation.Approximant, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);

        // Trills
        public static Consonant VoicedBilabialTrill = new("ʙ", PlaceOfArticulation.Bilabial, MannerOfArticulation.Trill, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedAlveolarTrill = new("r", PlaceOfArticulation.Alveolar, MannerOfArticulation.Trill, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedRetroflexTrill = new("ɽr", PlaceOfArticulation.Retroflex, MannerOfArticulation.Trill, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedUvularTrill = new("ʀ", PlaceOfArticulation.Uvular, MannerOfArticulation.Trill, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);

        // Taps and Flaps
        public static Consonant VoicedAlveolarTap = new("ɾ", PlaceOfArticulation.Alveolar, MannerOfArticulation.TapOrFlap, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedRetroflexTap = new("ɽ", PlaceOfArticulation.Retroflex, MannerOfArticulation.TapOrFlap, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);

        // Lateral Approximants
        public static Consonant VoicedAlveolarLateralApproximant = new("l", PlaceOfArticulation.Alveolar, MannerOfArticulation.LateralApproximant, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedRetroflexLateralApproximant = new("ɭ", PlaceOfArticulation.Retroflex, MannerOfArticulation.LateralApproximant, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedPalatalLateralApproximant = new("ʎ", PlaceOfArticulation.Palatal, MannerOfArticulation.LateralApproximant, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedVelarLateralApproximant = new("ʟ", PlaceOfArticulation.Velar, MannerOfArticulation.LateralApproximant, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
        public static Consonant VoicedPalatalLateralApproximantWithDiacritic = new("ʎ", PlaceOfArticulation.Palatal, MannerOfArticulation.LateralApproximant, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);

        // Lateral Fricatives
        public static Consonant VoicelessAlveolarLateralFricative = new("ɬ", PlaceOfArticulation.Alveolar, MannerOfArticulation.LateralFricative, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedAlveolarLateralFricative = new("ɮ", PlaceOfArticulation.Alveolar, MannerOfArticulation.LateralFricative, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);

        // Lateral Affricates
        public static Consonant VoicelessAlveolarLateralAffricate = new("tɬ", PlaceOfArticulation.Alveolar, MannerOfArticulation.LateralAffricate, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
        public static Consonant VoicedAlveolarLateralAffricate = new("dɮ", PlaceOfArticulation.Alveolar, MannerOfArticulation.LateralAffricate, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Obstruent);

        // Lateral Taps and Flaps
        public static Consonant VoicedAlveolarLateralTap = new("ɺ", PlaceOfArticulation.Alveolar, MannerOfArticulation.LateralTapOrFlap, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);


        // Clicks 
        public static Consonant VoicelessBilabialClick = new("ʘ", PlaceOfArticulation.Bilabial, MannerOfArticulation.Click, Voicing.Voiceless, Mechanism.NonPulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessDentalClick = new("ǀ", PlaceOfArticulation.Dental, MannerOfArticulation.Click, Voicing.Voiceless, Mechanism.NonPulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessAlveolarClick = new("ǃ", PlaceOfArticulation.Alveolar, MannerOfArticulation.Click, Voicing.Voiceless, Mechanism.NonPulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessPostalveolarClick = new("ǂ", PlaceOfArticulation.PostAlveolar, MannerOfArticulation.Click, Voicing.Voiceless, Mechanism.NonPulmonic, Sonorance.Obstruent);
        public static Consonant VoicelessPalatalClick = new("ǁ", PlaceOfArticulation.Palatal, MannerOfArticulation.Click, Voicing.Voiceless, Mechanism.NonPulmonic, Sonorance.Sonorant);

        public static Consonant VoicedBilabialClick = new("ᶢʘ", PlaceOfArticulation.Bilabial, MannerOfArticulation.Click, Voicing.Voiced, Mechanism.NonPulmonic, Sonorance.Obstruent);
        public static Consonant VoicedDentalClick = new("ᶢǀ", PlaceOfArticulation.Dental, MannerOfArticulation.Click, Voicing.Voiced, Mechanism.NonPulmonic, Sonorance.Obstruent);
        public static Consonant VoicedAlveolarClick = new("ᶢǃ", PlaceOfArticulation.Alveolar, MannerOfArticulation.Click, Voicing.Voiced, Mechanism.NonPulmonic, Sonorance.Obstruent);
        public static Consonant VoicedPostalveolarClick = new("ᶢǂ", PlaceOfArticulation.PostAlveolar, MannerOfArticulation.Click, Voicing.Voiced, Mechanism.NonPulmonic, Sonorance.Obstruent);
        public static Consonant VoicedPalatalClick = new("ᶢǁ", PlaceOfArticulation.Palatal, MannerOfArticulation.Click, Voicing.Voiced, Mechanism.NonPulmonic, Sonorance.Sonorant);

        // Implosives
        public static Consonant VoicedBilabialImplosive = new("ɓ", PlaceOfArticulation.Bilabial, MannerOfArticulation.Plosive, Voicing.Voiced, Mechanism.Implosive, Sonorance.Obstruent);
        public static Consonant VoicedAlveolarImplosive = new("ɗ", PlaceOfArticulation.Alveolar, MannerOfArticulation.Plosive, Voicing.Voiced, Mechanism.Implosive, Sonorance.Obstruent);
        public static Consonant VoicedRetroflexImplosive = new("ᶑ", PlaceOfArticulation.Retroflex, MannerOfArticulation.Plosive, Voicing.Voiced, Mechanism.Implosive, Sonorance.Obstruent);
        public static Consonant VoicedPalatalImplosive = new("ʛ", PlaceOfArticulation.Palatal, MannerOfArticulation.Plosive, Voicing.Voiced, Mechanism.Implosive, Sonorance.Obstruent);
        public static Consonant VoicedVelarImplosive = new("ɠ", PlaceOfArticulation.Velar, MannerOfArticulation.Plosive, Voicing.Voiced, Mechanism.Implosive, Sonorance.Obstruent);
        public static Consonant VoicedUvularImplosive = new("ʛ", PlaceOfArticulation.Uvular, MannerOfArticulation.Plosive, Voicing.Voiced, Mechanism.Implosive, Sonorance.Obstruent);

        // Ejectives
        public static Consonant VoicelessBilabialEjective = new("pʼ", PlaceOfArticulation.Bilabial, MannerOfArticulation.Plosive, Voicing.Voiceless, Mechanism.Ejective, Sonorance.Obstruent);
        public static Consonant VoicelessAlveolarEjective = new("tʼ", PlaceOfArticulation.Alveolar, MannerOfArticulation.Plosive, Voicing.Voiceless, Mechanism.Ejective, Sonorance.Obstruent);
        public static Consonant VoicelessVelarEjective = new("kʼ", PlaceOfArticulation.Velar, MannerOfArticulation.Plosive, Voicing.Voiceless, Mechanism.Ejective, Sonorance.Obstruent);
        public static Consonant VoicelessUvularEjective = new("qʼ", PlaceOfArticulation.Uvular, MannerOfArticulation.Plosive, Voicing.Voiceless, Mechanism.Ejective, Sonorance.Obstruent);


        // All Consonants List
        public static List<Consonant> AllConsonants = new List<Consonant>
        {
            // Nasals
            VoicelessBilabialNasalStop,
            VoicedBilabialNasal,
            VoicelessLabioDentalNasalStop,
            VoicedLabioDentalNasal,
            VoicelessAlveolarNasalStop,
            VoicedAlveolarNasal,
            VoicedAlveolarNasalRetroflex,
            VoicelessRetroflexNasalStop,
            VoicedVelarNasal,
            VoicelessVelarNasalStop,
            VoicedUvularNasal,

            // Plosives
            VoicelessBilabialPlosive,
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
            VoicelessGlottalPlosive,

            // Affricates
            VoicelessAlveolarSibilantAffricate,
            VoicedAlveolarSibilantAffricate,
            VoicelessPostalveolarSibilantAffricate,
            VoicedPostalveolarSibilantAffricate,
            VoicelessPalatalSibilantAffricate,
            VoicedPalatalSibilantAffricate,

            // Fricatives
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

            // Approximants
            VoicedBilabialApproximant,
            VoicedLabioDentalApproximant,
            VoicedAlveolarApproximant,
            VoicedRetroflexApproximant,
            VoicedPalatalApproximant,
            VoicedVelarApproximant,
            VoicedUvularApproximant,

            // Trills
            VoicedBilabialTrill,
            VoicedAlveolarTrill,
            VoicedRetroflexTrill,
            VoicedUvularTrill,

            // Taps and Flaps
            VoicedAlveolarTap,
            VoicedRetroflexTap,

            // Lateral Approximants
            VoicedAlveolarLateralApproximant,
            VoicedRetroflexLateralApproximant,
            VoicedPalatalLateralApproximant,
            VoicedVelarLateralApproximant,

            // Lateral Fricatives
            VoicelessAlveolarLateralFricative,
            VoicedAlveolarLateralFricative,

            // Lateral Affricates
            VoicelessAlveolarLateralAffricate,
            VoicedAlveolarLateralAffricate,

            // Lateral Taps and Flaps
            VoicedAlveolarLateralTap,


            // Clicks 
            VoicelessBilabialClick,
            VoicelessDentalClick ,
            VoicelessAlveolarClick,
            VoicelessPostalveolarClick,
            VoicelessPalatalClick            ,
            VoicedDentalClick,
            VoicedAlveolarClick ,
            VoicedPostalveolarClick,



            // Implosives
            VoicedBilabialImplosive,
            VoicedAlveolarImplosive,
            VoicedRetroflexImplosive,
            VoicedPalatalImplosive,
            VoicedVelarImplosive,
            VoicedUvularImplosive,

            // Ejectives
            VoicelessBilabialEjective,
            VoicelessAlveolarEjective,
            VoicelessVelarEjective,
            VoicelessUvularEjective,

            // Approximants 
            VoicedLabioVelarApproximant,

            // Lateral Approximants 
            VoicedPalatalLateralApproximantWithDiacritic
    };
    }
}
