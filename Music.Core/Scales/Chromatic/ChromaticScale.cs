namespace Music.Core.Scales.Chromatic
{
    public class ChromaticScale : ScaleBase
    {
        public ChromaticScale(Note rootNote)
            : base("Chromatic", rootNote,
                   ScaleFamilies.ChromaticScaleFamily,
                   ChromaticScaleFamily.DefaultMode)
        {
        }
    }
}
