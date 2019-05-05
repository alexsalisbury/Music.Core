using Music.Core.Scales.Diatonic;
using Xunit;

namespace Music.Core.Tests
{
    public class LocrianModeTests
    {
        [Fact]
        public void TestLocrianScaleNoteIntervals()
        {
            var scale = new LocrianScale(MusicNotes.A);

            Assert.Equal(IntervalQuality.P1, scale.Notes[0].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m2, scale.Notes[1].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m3, scale.Notes[2].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.P4, scale.Notes[3].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.d5, scale.Notes[4].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m6, scale.Notes[5].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m7, scale.Notes[6].Interval.IntervalQuality);
        }

        [Fact]
        public void TestAFlatLocrian()
        {
            var scale = new LocrianScale(MusicNotes.AFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BDoubleFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.EDoubleFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestALocrian()
        {
            var scale = new LocrianScale(MusicNotes.A);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.A, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[6].Note);
        }

        [Fact]
        public void TestASharpLocrian()
        {
            var scale = new LocrianScale(MusicNotes.ASharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestBFlatLocrian()
        {
            var scale = new LocrianScale(MusicNotes.BFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestBLocrian()
        {
            var scale = new LocrianScale(MusicNotes.B);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.B, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[6].Note);
        }

        [Fact]
        public void TestCLocrian()
        {
            var scale = new LocrianScale(MusicNotes.C);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.C, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestCSharpLocrian()
        {
            var scale = new LocrianScale(MusicNotes.CSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[6].Note);
        }

        [Fact]
        public void TestDFlatLocrian()
        {
            var scale = new LocrianScale(MusicNotes.DFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.EDoubleFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.ADoubleFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.BDoubleFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestDLocrian()
        {
            var scale = new LocrianScale(MusicNotes.D);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.D, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[6].Note);
        }

        [Fact]
        public void TestDSharpLocrian()
        {
            var scale = new LocrianScale(MusicNotes.DSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestEFlatLocrian()
        {
            var scale = new LocrianScale(MusicNotes.EFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.BDoubleFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestELocrian()
        {
            var scale = new LocrianScale(MusicNotes.E);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.E, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[6].Note);
        }

        [Fact]
        public void TestFLocrian()
        {
            var scale = new LocrianScale(MusicNotes.F);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.F, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestFSharpLocrian()
        {
            var scale = new LocrianScale(MusicNotes.FSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[6].Note);
        }

        [Fact]
        public void TestGFlatLocrian()
        {
            var scale = new LocrianScale(MusicNotes.GFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.ADoubleFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.BDoubleFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.DDoubleFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.EDoubleFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestGLocrian()
        {
            var scale = new LocrianScale(MusicNotes.G);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.G, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[6].Note);
        }

        [Fact]
        public void TestGSharpLocrian()
        {
            var scale = new LocrianScale(MusicNotes.GSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[6].Note);
        }
    }
}
