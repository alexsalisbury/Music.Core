using Music.Core.Scales.Diatonic;
using Xunit;

namespace Music.Core.Tests
{
    public class MixolydianModeTests
    {
        [Fact]
        public void TestMixolydianScaleNoteIntervals()
        {
            var scale = new MixolydianScale(MusicNotes.A);

            Assert.Equal(IntervalQuality.P1, scale.Notes[0].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.M2, scale.Notes[1].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.M3, scale.Notes[2].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.P4, scale.Notes[3].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.P5, scale.Notes[4].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.M6, scale.Notes[5].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.m7, scale.Notes[6].Interval.IntervalQuality);
        }

        [Fact]
        public void TestAFlatMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.AFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestAMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.A);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.A, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[6].Note);
        }

        [Fact]
        public void TestASharpMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.ASharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.CDoubleSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.FDoubleSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestBFlatMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.BFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestBMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.B);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.B, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[6].Note);
        }

        [Fact]
        public void TestCMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.C);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.C, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestCSharpMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.CSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[6].Note);
        }

        [Fact]
        public void TestDFlatMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.DFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestDMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.D);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.D, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[6].Note);
        }

        [Fact]
        public void TestDSharpMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.DSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.FDoubleSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.BSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestEFlatMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.EFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestEMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.E);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.E, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[6].Note);
        }

        [Fact]
        public void TestFMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.F);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.F, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestFSharpMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.FSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[6].Note);
        }

        [Fact]
        public void TestGFlatMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.GFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.FFlat, scale.Notes[6].Note);
        }

        [Fact]
        public void TestGMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.G);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.G, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[6].Note);
        }

        [Fact]
        public void TestGSharpMixolydian()
        {
            var scale = new MixolydianScale(MusicNotes.GSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.BSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[6].Note);
        }
    }
}
