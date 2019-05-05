using Music.Core.Scales.Chromatic;
using Xunit;

namespace Music.Core.Tests
{
    public class ChromaticScaleTests
    {
        [Fact]
        public void TestChromaticScaleNoteIntervals()
        {
            var scale = new ChromaticScale(MusicNotes.A);

            Assert.Equal(IntervalQuality.P1, scale.Notes[0].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m2, scale.Notes[1].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.M2, scale.Notes[2].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m3, scale.Notes[3].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.M3, scale.Notes[4].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.P4, scale.Notes[5].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.d5, scale.Notes[6].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.P5, scale.Notes[7].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m6, scale.Notes[8].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.M6, scale.Notes[9].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m7, scale.Notes[10].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.M7, scale.Notes[11].Interval.IntervalQuality);
        }

        [Fact]
        public void TestAFlatChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.AFlat);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BDoubleFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.EDoubleFlat, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[11].Note);
        }

        [Fact]
        public void TestANaturalChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.A);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.A, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[11].Note);
        }

        [Fact]
        public void TestASharpChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.ASharp);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.BSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.CDoubleSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.FDoubleSharp, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.GDoubleSharp, scale.Notes[11].Note);
        }

        [Fact]
        public void TestBFlatChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.BFlat);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[11].Note);
        }

        [Fact]
        public void TestBNaturalChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.B);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.B, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[11].Note);
        }

        [Fact]
        public void TestCNaturalChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.C);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.C, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[11].Note);
        }

        [Fact]
        public void TestCSharpChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.CSharp);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.BSharp, scale.Notes[11].Note);
        }

        [Fact]
        public void TestDFlatChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.DFlat);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.EDoubleFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.ADoubleFlat, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.BDoubleFlat, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[11].Note);
        }

        [Fact]
        public void TestDNaturalChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.D);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.D, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[11].Note);
        }

        [Fact]
        public void TestDSharpChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.DSharp);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.FDoubleSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.BSharp, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.CDoubleSharp, scale.Notes[11].Note);
        }

        [Fact]
        public void TestEFlatChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.EFlat);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.BDoubleFlat, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[11].Note);
        }

        [Fact]
        public void TestENaturalChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.E);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.E, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[11].Note);
        }

        [Fact]
        public void TestFNaturalChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.F);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.F, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[11].Note);
        }

        [Fact]
        public void TestFSharpChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.FSharp);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[11].Note);
        }

        [Fact]
        public void TestGFlatChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.GFlat);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.ADoubleFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.BDoubleFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.DDoubleFlat, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.EDoubleFlat, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[11].Note);
        }

        [Fact]
        public void TestGNaturalChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.G);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.G, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[11].Note);
        }

        [Fact]
        public void TestGSharpChromatic()
        {
            var scale = new ChromaticScale(MusicNotes.GSharp);

            Assert.Equal(12, scale.Notes.Length);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.BSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[6].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[7].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[8].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[9].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[10].Note);

            Assert.Equal(MusicNotes.FDoubleSharp, scale.Notes[11].Note);
        }
    }
}
