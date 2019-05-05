namespace Music.Core.Scales.Pentatonic
{
    public class MinorPentatonicScale : ScaleBase
    {
        public MinorPentatonicScale(Note rootNote)
            : base("Minor Pentatonic", rootNote,
                   ScaleFamilies.PentatonicScaleFamily,
                   PentatonicScaleFamily.MinorMode)
        {
        }
    }
}
