namespace Music.Core.Scales.Pentatonic
{
    public class MajorPentatonicScale : ScaleBase
    {
        public MajorPentatonicScale(Note rootNote)
            : base("Major Pentatonic", rootNote,
                   ScaleFamilies.PentatonicScaleFamily,
                   PentatonicScaleFamily.MajorMode)
        {
        }
    }
}
