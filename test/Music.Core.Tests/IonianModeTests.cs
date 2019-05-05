using Music.Core.Scales.Diatonic;
using Xunit;

namespace Music.Core.Tests
{
    public class IonianModeTests
    {
        [Fact]
        public void TestMajorScaleNoteIntervals()
        {
            var scale = new IonianScale(MusicNotes.A);

            Assert.Equal(IntervalQuality.P1, scale.Notes[0].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.M2, scale.Notes[1].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.M3, scale.Notes[2].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.P4, scale.Notes[3].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.P5, scale.Notes[4].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.M6, scale.Notes[5].Interval.IntervalQuality);
            Assert.Equal(IntervalQuality.M7, scale.Notes[6].Interval.IntervalQuality);
        }

        [Fact]
        public void TestAFlatMajor()
        {
            var scale = new IonianScale(MusicNotes.AFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[6].Note);
        }

        [Fact]
        public void TestAMajor()
        {
            var scale = new IonianScale(MusicNotes.A);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.A, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestASharpMajor()
        {
            var scale = new IonianScale(MusicNotes.ASharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.BSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.CDoubleSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.FDoubleSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.GDoubleSharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestBFlatMajor()
        {
            var scale = new IonianScale(MusicNotes.BFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[6].Note);
        }

        [Fact]
        public void TestBMajor()
        {
            var scale = new IonianScale(MusicNotes.B);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.B, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestCMajor()
        {
            var scale = new IonianScale(MusicNotes.C);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.C, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[6].Note);
        }

        [Fact]
        public void TestCSharpMajor()
        {
            var scale = new IonianScale(MusicNotes.CSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.BSharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestDFlatMajor()
        {
            var scale = new IonianScale(MusicNotes.DFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[6].Note);
        }

        [Fact]
        public void TestDMajor()
        {
            var scale = new IonianScale(MusicNotes.D);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.D, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestDSharpMajor()
        {
            var scale = new IonianScale(MusicNotes.DSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.FDoubleSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.BSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.CDoubleSharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestEFlatMajor()
        {
            var scale = new IonianScale(MusicNotes.EFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[6].Note);
        }

        [Fact]
        public void TestEMajor()
        {
            var scale = new IonianScale(MusicNotes.E);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.E, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestFMajor()
        {
            var scale = new IonianScale(MusicNotes.F);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.F, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.G, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[6].Note);
        }

        [Fact]
        public void TestFSharpMajor()
        {
            var scale = new IonianScale(MusicNotes.FSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestGFlatMajor()
        {
            var scale = new IonianScale(MusicNotes.GFlat);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.GFlat, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.AFlat, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.BFlat, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.CFlat, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.DFlat, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.EFlat, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.F, scale.Notes[6].Note);
        }

        [Fact]
        public void TestGMajor()
        {
            var scale = new IonianScale(MusicNotes.G);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.G, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.A, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.B, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.C, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.D, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.E, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.FSharp, scale.Notes[6].Note);
        }

        [Fact]
        public void TestGSharpMajor()
        {
            var scale = new IonianScale(MusicNotes.GSharp);

            Assert.Equal(7, scale.Notes.Length);

            Assert.Equal(MusicNotes.GSharp, scale.Notes[0].Note);

            Assert.Equal(MusicNotes.ASharp, scale.Notes[1].Note);

            Assert.Equal(MusicNotes.BSharp, scale.Notes[2].Note);

            Assert.Equal(MusicNotes.CSharp, scale.Notes[3].Note);

            Assert.Equal(MusicNotes.DSharp, scale.Notes[4].Note);

            Assert.Equal(MusicNotes.ESharp, scale.Notes[5].Note);

            Assert.Equal(MusicNotes.FDoubleSharp, scale.Notes[6].Note);
        }
    }
}
