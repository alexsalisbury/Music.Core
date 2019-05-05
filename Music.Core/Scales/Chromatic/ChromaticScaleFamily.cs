namespace Music.Core.Scales.Chromatic
{
    public sealed class ChromaticScaleFamily : ScaleFamily
    {
        public ChromaticScaleFamily()
            : base("Chromatic", new[] { true, true, true, true, true, true, true, true, true, true, true, true }, new[] { DefaultMode })
        {
        }

        public static readonly ScaleFamilyMode DefaultMode = new ScaleFamilyMode("Default", 0);
    }
}
