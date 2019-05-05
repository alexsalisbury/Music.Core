namespace Music.Core.Scales.Diatonic
{
    public class DorianScale : ScaleBase
    {
        public DorianScale(Note rootNote)
            : base("Dorian", rootNote,
                   ScaleFamilies.DiatonicScaleFamily,
                   DiatonicScaleFamily.DorianMode)
        {
        }
    }
}
