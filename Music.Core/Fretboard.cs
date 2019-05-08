using System.Collections.Generic;
using System.Linq;

namespace Music.Core
{
    public class Fretboard
    {
        public Note[] StringTuning { get; }
        public List<ScaleNote[]> StringNotes { get; private set; }

        public int NumberOfString => StringNotes.Count;
        public int NumberOfFrets { get; }

        public Fretboard(Note[] stringTuning, int numberOfFrets)
        {
            StringTuning = stringTuning;
            NumberOfFrets = numberOfFrets + 1;
        }

        public void SetScale(ScaleBase scale)
        {
            StringNotes = new List<ScaleNote[]>();

            foreach (var note in StringTuning)
            {
                var notes = new ScaleNote[NumberOfFrets];
                notes[0] = scale.ChromaticNotes.First(x => x.Note.Index == note.Index);

                StringNotes.Add(notes);
            }

            foreach (var s in StringNotes)
            {
                var scaleNote = s[0];
                var openNoteIndex = scaleNote.Note.Index;

                for (int i = 1; i < NumberOfFrets; i++)
                {
                    var noteIndex = (openNoteIndex + i) % 12;
                    scaleNote = scale.ChromaticNotes.First(x => x.Note.Index == noteIndex);

                    s[i] = scaleNote;
                }
            }
        }
    }
}
