namespace Music.Core.Scales.Diatonic
{
    public class IonianScale : ScaleBase
    {
        public IonianScale(Note rootNote)
            : base("Ionian", rootNote,
                   ScaleFamilies.DiatonicScaleFamily,
                   DiatonicScaleFamily.IonianMode)
        {
        }
    }
}
