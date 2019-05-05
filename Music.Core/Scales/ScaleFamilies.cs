using Music.Core.Scales.Chromatic;
using Music.Core.Scales.Diatonic;
using Music.Core.Scales.Pentatonic;

namespace Music.Core.Scales
{
    public static class ScaleFamilies
    {
        public static readonly ScaleFamily ChromaticScaleFamily = new ChromaticScaleFamily();
        public static readonly ScaleFamily DiatonicScaleFamily = new DiatonicScaleFamily();
        public static readonly ScaleFamily PentatonicScaleFamily = new PentatonicScaleFamily();
    }
}
