using Music.Core.Scales.Pentatonic;
using Xunit;

namespace Music.Core.Tests
{
    public class MinorPentatonicScaleTests
    {
        [Fact]
        public void TestMinorPentatonicScaleNoteIntervals()
        {
            var scale = new MinorPentatonicScale(MusicNotes.A);

            Assert.Equal(IntervalQuality.P1, scale.Notes[0].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m3, scale.Notes[1].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.P4, scale.Notes[2].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.P5, scale.Notes[3].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m7, scale.Notes[4].Interval.IntervalQuality);
        }

        [Fact]
        public void TestAFlatMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.AFlat);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[4].Note);
        }

        [Fact]
        public void TestAMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.A);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.A, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[4].Note);
        }

        [Fact]
        public void TestASharpMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.ASharp);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[4].Note);
        }

        [Fact]
        public void TestBFlatMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.BFlat);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[4].Note);
        }

        [Fact]
        public void TestBMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.B);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.B, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[4].Note);
        }

        [Fact]
        public void TestCMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.C);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.C, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[4].Note);
        }

        [Fact]
        public void TestCSharpMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.CSharp);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[4].Note);
        }

        [Fact]
        public void TestDFlatMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.DFlat);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[4].Note);
        }

        [Fact]
        public void TestDMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.D);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.D, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[4].Note);
        }

        [Fact]
        public void TestDSharpMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.DSharp);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[4].Note);
        }

        [Fact]
        public void TestEFlatMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.EFlat);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[4].Note);
        }

        [Fact]
        public void TestEMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.E);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.E, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[4].Note);
        }

        [Fact]
        public void TestFMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.F);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.F, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[4].Note);
        }

        [Fact]
        public void TestFSharpMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.FSharp);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[4].Note);
        }

        [Fact]
        public void TestGFlatMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.GFlat);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BDoubleFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[4].Note);
        }

        [Fact]
        public void TestGMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.G);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.G, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[4].Note);
        }

        [Fact]
        public void TestGSharpMinorPentatonic()
        {
            var scale = new MinorPentatonicScale(MusicNotes.GSharp);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[4].Note);
        }
    }
}
