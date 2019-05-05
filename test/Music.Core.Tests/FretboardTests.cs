using Music.Core.Scales.Diatonic;
using Xunit;

namespace Music.Core.Tests
{
    public class FretboardTests
    {
        [Fact]
        public void TestAFlatLydianOnEString()
        {
            var scale = new LydianScale(MusicNotes.AFlat);
            var fretboard = new Fretboard(new[] { MusicNotes.E }, 12);

            fretboard.SetScale(scale);

            Assert.Equal(MusicNotes.FFlat, fretboard.StringNotes[0][0]);
            Assert.Equal(MusicNotes.F, fretboard.StringNotes[0][1]);
            Assert.Equal(MusicNotes.GFlat, fretboard.StringNotes[0][2]);
            Assert.Equal(MusicNotes.G, fretboard.StringNotes[0][3]);
            Assert.Equal(MusicNotes.AFlat, fretboard.StringNotes[0][4]);
            Assert.Equal(MusicNotes.BDoubleFlat, fretboard.StringNotes[0][5]);
            Assert.Equal(MusicNotes.BFlat, fretboard.StringNotes[0][6]);
            Assert.Equal(MusicNotes.CFlat, fretboard.StringNotes[0][7]);
            Assert.Equal(MusicNotes.C, fretboard.StringNotes[0][8]);
            Assert.Equal(MusicNotes.DFlat, fretboard.StringNotes[0][9]);
            Assert.Equal(MusicNotes.D, fretboard.StringNotes[0][10]);
            Assert.Equal(MusicNotes.EFlat, fretboard.StringNotes[0][11]);
            Assert.Equal(MusicNotes.FFlat, fretboard.StringNotes[0][12]);
        }
    }
}
