namespace Music.Core.Scales.Diatonic
{
    public class AeolianScale : ScaleBase
    {
        public AeolianScale(Note rootNote)
            : base("Aeolian", rootNote,
                   ScaleFamilies.DiatonicScaleFamily,
                   DiatonicScaleFamily.AeolianMode)
        {
        }
    }
}
