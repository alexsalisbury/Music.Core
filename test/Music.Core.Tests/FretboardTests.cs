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

            Assert.Equal(MusicNotes.FFlat, fretboard.StringNotes[0][0].Note);
            Assert.Equal(MusicNotes.F, fretboard.StringNotes[0][1].Note);
            Assert.Equal(MusicNotes.GFlat, fretboard.StringNotes[0][2].Note);
            Assert.Equal(MusicNotes.G, fretboard.StringNotes[0][3].Note);
            Assert.Equal(MusicNotes.AFlat, fretboard.StringNotes[0][4].Note);
            Assert.Equal(MusicNotes.BDoubleFlat, fretboard.StringNotes[0][5].Note);
            Assert.Equal(MusicNotes.BFlat, fretboard.StringNotes[0][6].Note);
            Assert.Equal(MusicNotes.CFlat, fretboard.StringNotes[0][7].Note);
            Assert.Equal(MusicNotes.C, fretboard.StringNotes[0][8].Note);
            Assert.Equal(MusicNotes.DFlat, fretboard.StringNotes[0][9].Note);
            Assert.Equal(MusicNotes.D, fretboard.StringNotes[0][10].Note);
            Assert.Equal(MusicNotes.EFlat, fretboard.StringNotes[0][11].Note);
            Assert.Equal(MusicNotes.FFlat, fretboard.StringNotes[0][12].Note);
        }
    }
}
