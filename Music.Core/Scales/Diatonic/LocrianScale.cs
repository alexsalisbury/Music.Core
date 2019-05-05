namespace Music.Core.Scales.Diatonic
{
    public class LocrianScale : ScaleBase
    {
        public LocrianScale(Note rootNote)
            : base("Locrian", rootNote,
                   ScaleFamilies.DiatonicScaleFamily,
                   DiatonicScaleFamily.LocrianMode)
        {
        }
    }
}
