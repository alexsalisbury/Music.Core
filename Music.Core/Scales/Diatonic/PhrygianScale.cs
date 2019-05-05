namespace Music.Core.Scales.Diatonic
{
    public class PhrygianScale : ScaleBase
    {
        public PhrygianScale(Note rootNote)
            : base("Phrygian", rootNote,
                   ScaleFamilies.DiatonicScaleFamily,
                   DiatonicScaleFamily.PhrygianMode)
        {
        }
    }
}
