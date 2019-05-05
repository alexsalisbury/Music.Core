using Music.Core.Scales.Pentatonic;
using Xunit;

namespace Music.Core.Tests
{
    public class MajorPentatonicScaleTests
    {
        [Fact]
        public void TestMajorPentatonicScaleNoteIntervals()
        {
            var scale = new MajorPentatonicScale(MusicNotes.A);

            Assert.Equal(IntervalQuality.P1, scale.Notes[0].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.M2, scale.Notes[1].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.M3, scale.Notes[2].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.P5, scale.Notes[3].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.M6, scale.Notes[4].Interval.IntervalQuality);
        }

        [Fact]
        public void TestAFlatMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.AFlat);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[4].Note);
        }

        [Fact]
        public void TestAMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.A);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.A, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[4].Note);
        }

        [Fact]
        public void TestASharpMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.ASharp);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.CDoubleSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.FDoubleSharp, scale.Notes[4].Note);
        }

        [Fact]
        public void TestBFlatMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.BFlat);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[4].Note);
        }

        [Fact]
        public void TestBMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.B);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.B, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[4].Note);
        }

        [Fact]
        public void TestCMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.C);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.C, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[4].Note);
        }

        [Fact]
        public void TestCSharpMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.CSharp);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[4].Note);
        }

        [Fact]
        public void TestDFlatPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.DFlat);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[4].Note);
        }

        [Fact]
        public void TestDMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.D);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.D, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[4].Note);
        }

        [Fact]
        public void TestDSharpMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.DSharp);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.FDoubleSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.BSharp, scale.Notes[4].Note);
        }

        [Fact]
        public void TestEFlatMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.EFlat);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[4].Note);
        }

        [Fact]
        public void TestEMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.E);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.E, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[4].Note);
        }

        [Fact]
        public void TestFMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.F);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.F, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[4].Note);
        }

        [Fact]
        public void TestFSharpMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.FSharp);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[4].Note);
        }

        [Fact]
        public void TestGFlatMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.GFlat);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[4].Note);
        }

        [Fact]
        public void TestGMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.G);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.G, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[4].Note);
        }

        [Fact]
        public void TestGSharpMajorPentatonic()
        {
            var scale = new MajorPentatonicScale(MusicNotes.GSharp);

            Assert.Equal(5, scale.Notes.Length);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.BSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[4].Note);
        }
    }
}
