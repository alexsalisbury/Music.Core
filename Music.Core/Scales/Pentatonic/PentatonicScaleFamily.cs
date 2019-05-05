namespace Music.Core.Scales.Pentatonic
{
    public sealed class PentatonicScaleFamily : ScaleFamily
    {
        public PentatonicScaleFamily()
            : base("Pentatonic",
                   new[] { true, false, true, false, true, false, false, true, false, true, false, false },
                   new[] { MajorMode, MinorMode })
        {
        }

        public static readonly ScaleFamilyMode MajorMode = new ScaleFamilyMode("Major", 0);
        public static readonly ScaleFamilyMode MinorMode = new ScaleFamilyMode("Minor", 9);
    }
}
