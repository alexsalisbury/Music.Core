namespace Music.Core.Scales.Diatonic
{
    public sealed class DiatonicScaleFamily : ScaleFamily
    {
        public DiatonicScaleFamily()
            : base("Diatonic",
                   new[] { true, false, true, false, true, true, false, true, false, true, false, true },
                   new[] { IonianMode, DorianMode, PhrygianMode, LydianMode, MixolydianMode, AeolianMode, LocrianMode })
        {
        }

        public static readonly ScaleFamilyMode IonianMode = new ScaleFamilyMode("Ionian", 0);
        public static readonly ScaleFamilyMode DorianMode = new ScaleFamilyMode("Dorian", 2);
        public static readonly ScaleFamilyMode PhrygianMode = new ScaleFamilyMode("Phrygian", 4);
        public static readonly ScaleFamilyMode LydianMode = new ScaleFamilyMode("Lydian", 5);
        public static readonly ScaleFamilyMode MixolydianMode = new ScaleFamilyMode("Mixolydian", 7);
        public static readonly ScaleFamilyMode AeolianMode = new ScaleFamilyMode("Aeolian", 9);
        public static readonly ScaleFamilyMode LocrianMode = new ScaleFamilyMode("Locrian", 11);
    }
}
