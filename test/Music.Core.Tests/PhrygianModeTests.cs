using Music.Core.Scales.Diatonic;
using Xunit;

namespace Music.Core.Tests
{
    public class PhrygianModeTests
    {
        [Fact]
        public void TestPhrygianScaleNoteIntervals()
        {
            var scale = new PhrygianScale(MusicNotes.A);

            Assert.Equal(IntervalQuality.P1, scale.Notes[0].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m2, scale.Notes[1].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m3, scale.Notes[2].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.P4, scale.Notes[3].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.P5, scale.Notes[4].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m6, scale.Notes[5].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m7, scale.Notes[6].Interval.IntervalQuality);
        }

        [Fact]
        public void TestAFlatPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.AFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BDoubleFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestAPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.A);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.A, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[6].Note);
        }

        [Fact]
        public void TestASharpPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.ASharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestBFlatPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.BFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestBPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.B);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.B, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[6].Note);
        }

        [Fact]
        public void TestCPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.C);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.C, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestCSharpPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.CSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[6].Note);
        }

        [Fact]
        public void TestDFlatPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.DFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.EDoubleFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.BDoubleFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestDPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.D);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.D, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[6].Note);
        }

        [Fact]
        public void TestDSharpPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.DSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestEFlatPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.EFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestEPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.E);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.E, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[6].Note);
        }

        [Fact]
        public void TestFPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.F);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.F, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestFSharpPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.FSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[6].Note);
        }

        [Fact]
        public void TestGFlatPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.GFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.ADoubleFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.BDoubleFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.EDoubleFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestGPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.G);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.G, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[6].Note);
        }

        [Fact]
        public void TestGSharpPhrygian()
        {
            var scale = new PhrygianScale(MusicNotes.GSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[6].Note);
        }
    }
}
