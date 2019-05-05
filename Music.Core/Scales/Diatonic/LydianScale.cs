namespace Music.Core.Scales.Diatonic
{
    public class LydianScale : ScaleBase
    {
        public LydianScale(Note rootNote)
            : base("Lydian", rootNote,
                   ScaleFamilies.DiatonicScaleFamily,
                   DiatonicScaleFamily.LydianMode)
        {
        }
    }
}
