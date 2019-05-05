namespace Music.Core.Scales.Diatonic
{
    public class MixolydianScale : ScaleBase
    {
        public MixolydianScale(Note rootNote)
            : base("Mixolydian", rootNote,
                   ScaleFamilies.DiatonicScaleFamily,
                   DiatonicScaleFamily.MixolydianMode)
        {
        }
    }
}
