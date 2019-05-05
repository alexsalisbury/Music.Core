using Music.Core.Scales.Diatonic;
using Xunit;

namespace Music.Core.Tests
{
    public class AeolianModeTests
    {
        [Fact]
        public void TestAeolianScaleNoteIntervals()
        {
            var scale = new AeolianScale(MusicNotes.A);

            Assert.Equal(IntervalQuality.P1, scale.Notes[0].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.M2, scale.Notes[1].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m3, scale.Notes[2].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.P4, scale.Notes[3].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.P5, scale.Notes[4].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m6, scale.Notes[5].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m7, scale.Notes[6].Interval.IntervalQuality);
        }

        [Fact]
        public void TestAFlatMinor()
        {
            var scale = new AeolianScale(MusicNotes.AFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestAMinor()
        {
            var scale = new AeolianScale(MusicNotes.A);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.A, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[6].Note);
        }

        [Fact]
        public void TestASharpMinor()
        {
            var scale = new AeolianScale(MusicNotes.ASharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestBFlatMinor()
        {
            var scale = new AeolianScale(MusicNotes.BFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestBMinor()
        {
            var scale = new AeolianScale(MusicNotes.B);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.B, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[6].Note);
        }

        [Fact]
        public void TestCMinor()
        {
            var scale = new AeolianScale(MusicNotes.C);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.C, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestCSharpMinor()
        {
            var scale = new AeolianScale(MusicNotes.CSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[6].Note);
        }

        [Fact]
        public void TestDFlatMinor()
        {
            var scale = new AeolianScale(MusicNotes.DFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.BDoubleFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestDMinor()
        {
            var scale = new AeolianScale(MusicNotes.D);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.D, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[6].Note);
        }

        [Fact]
        public void TestDSharpMinor()
        {
            var scale = new AeolianScale(MusicNotes.DSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestEFlatMinor()
        {
            var scale = new AeolianScale(MusicNotes.EFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestEMinor()
        {
            var scale = new AeolianScale(MusicNotes.E);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.E, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[6].Note);
        }

        [Fact]
        public void TestFMinor()
        {
            var scale = new AeolianScale(MusicNotes.F);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.F, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestFSharpMinor()
        {
            var scale = new AeolianScale(MusicNotes.FSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[6].Note);
        }

        [Fact]
        public void TestGFlatMinor()
        {
            var scale = new AeolianScale(MusicNotes.GFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.BDoubleFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.EDoubleFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestGMinor()
        {
            var scale = new AeolianScale(MusicNotes.G);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.G, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[6].Note);
        }

        [Fact]
        public void TestGSharpMinor()
        {
            var scale = new AeolianScale(MusicNotes.GSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[6].Note);
        }
    }
}
