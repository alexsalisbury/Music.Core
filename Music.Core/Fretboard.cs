using System.Collections.Generic;
using System.Linq;

namespace Music.Core
{
    public class Fretboard
    {
        public Note[] StringTuning { get; }
        public List<Note[]> StringNotes { get; private set; }

        public int NumberOfString => StringNotes.Count;
        public int NumberOfFrets { get; }

        public Fretboard(Note[] stringTuning, int numberOfFrets)
        {
            StringTuning = stringTuning;
            NumberOfFrets = numberOfFrets + 1;
        }

        public void SetScale(ScaleBase scale)
        {
            StringNotes = new List<Note[]>();

            foreach (var note in StringTuning)
            {
                var notes = new Note[NumberOfFrets];
                notes[0] = note;

                StringNotes.Add(notes);
            }

            foreach (var s in StringNotes)
            {
                var note = s[0];
                var openNoteIndex = note.Index;

                for (int i = 0; i < NumberOfFrets; i++)
                {
                    var noteIndex = (openNoteIndex + i) % 12;
                    note = scale.ChromaticNotes.First(x => x.Note.Index == noteIndex).Note;

                    s[i] = note;
                }
            }
        }
    }
}
