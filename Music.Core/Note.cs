using System;
using System.Linq;

namespace Music.Core
{
    public sealed class Note
    {
        public int Index { get; }
        public string Name { get; }
        public NoteLabel Label { get; }
        public Note Natural { get; }
        public string Description { get; }

        internal Note(int index, string name)
            : this(index, name, MusicNoteLabels.Major)
        {
        }

        internal Note(int index, string name, NoteLabel label)
        {
            Index = index;
            Name = name;
            Label = label;
            Description = Name + label.Label;
        }

        internal Note(int index, string name, NoteLabel label, Note natural)
            : this(index, name, label)
        {
            Natural = natural;
        }

        public override string ToString() => Description;
    }

    public static class MusicNoteLabels
    {
        public static readonly NoteLabel DoubleFlat = new NoteLabel(-2, "♭♭");
        public static readonly NoteLabel Flat = new NoteLabel(-1, "♭");
        public static readonly NoteLabel Major = new NoteLabel(0, "");
        public static readonly NoteLabel Sharp = new NoteLabel(1, "♯");
        public static readonly NoteLabel DoubleSharp = new NoteLabel(2, "x");

        public static readonly NoteLabel[] Labels =
        {
            DoubleFlat,
            Flat,
            Major,
            Sharp,
            DoubleSharp
        };
    }

    public static class MusicNotes
    {
        public static readonly Note A = new Note(0, "A");
        public static readonly Note B = new Note(2, "B");
        public static readonly Note C = new Note(3, "C");
        public static readonly Note D = new Note(5, "D");
        public static readonly Note E = new Note(7, "E");
        public static readonly Note F = new Note(8, "F");
        public static readonly Note G = new Note(10, "G");
        public static readonly Note ADoubleFlat = new Note(10, "A", MusicNoteLabels.DoubleFlat, A);
        public static readonly Note AFlat = new Note(11, "A", MusicNoteLabels.Flat, A);
        public static readonly Note ASharp = new Note(1, "A", MusicNoteLabels.Sharp, A);
        public static readonly Note BDoubleFlat = new Note(0, "B", MusicNoteLabels.DoubleFlat, B);
        public static readonly Note BFlat = new Note(1, "B", MusicNoteLabels.Flat, B);
        public static readonly Note BSharp = new Note(3, "B", MusicNoteLabels.Sharp, B);
        public static readonly Note CFlat = new Note(2, "C", MusicNoteLabels.Flat, C);
        public static readonly Note CSharp = new Note(4, "C", MusicNoteLabels.Sharp, C);
        public static readonly Note CDoubleSharp = new Note(5, "C", MusicNoteLabels.DoubleSharp, C);
        public static readonly Note DDoubleFlat = new Note(3, "D", MusicNoteLabels.DoubleFlat, D);
        public static readonly Note DFlat = new Note(4, "D", MusicNoteLabels.Flat, D);
        public static readonly Note DSharp = new Note(6, "D", MusicNoteLabels.Sharp, D);
        public static readonly Note DDoubleSharp = new Note(7, "D", MusicNoteLabels.DoubleSharp, D);
        public static readonly Note EDoubleFlat = new Note(5, "E", MusicNoteLabels.DoubleFlat, E);
        public static readonly Note EFlat = new Note(6, "E", MusicNoteLabels.Flat, E);
        public static readonly Note ESharp = new Note(8, "E", MusicNoteLabels.Sharp, E);
        public static readonly Note FFlat = new Note(7, "F", MusicNoteLabels.Flat, F);
        public static readonly Note FSharp = new Note(9, "F", MusicNoteLabels.Sharp, F);
        public static readonly Note FDoubleSharp = new Note(10, "F", MusicNoteLabels.DoubleSharp, F);
        public static readonly Note GFlat = new Note(9, "G", MusicNoteLabels.Flat, G);
        public static readonly Note GSharp = new Note(11, "G", MusicNoteLabels.Sharp, G);
        public static readonly Note GDoubleSharp = new Note(0, "G", MusicNoteLabels.DoubleSharp, G);

        public static readonly Note[] NaturalNotes =
        {
            A,
            B,
            C,
            D,
            E,
            F,
            G
        };

        public static readonly Note[] Notes =
        {
            ADoubleFlat,
            AFlat,
            A,
            ASharp,
            BDoubleFlat,
            BFlat,
            B,
            BSharp,
            CFlat,
            C,
            CSharp,
            CDoubleSharp,
            DDoubleFlat,
            DFlat,
            D,
            DSharp,
            DDoubleSharp,
            EDoubleFlat,
            EFlat,
            E,
            ESharp,
            FFlat,
            F,
            FSharp,
            FDoubleSharp,
            GFlat,
            G,
            GSharp,
            GDoubleSharp
        };

        public static Note FromString(string note)
        {
            if (string.IsNullOrWhiteSpace(note))
            {
                throw new ArgumentException("Note must be defined", nameof(note));
            }

            var natural = note.Substring(0, 1).ToUpper();
            if (!NaturalNotes.Any(x => x.Name == natural))
            {
                throw new ArgumentException($"Note {natural} was not found", nameof(note));
            }

            var noteLabel = MusicNoteLabels.Major;
            if (note.Length > 1)
            {
                var label = note.Substring(1, 1).ToLower();
                switch (label)
                {
                    case "b":
                        noteLabel = MusicNoteLabels.Flat;
                        break;
                    case "#":
                        noteLabel = MusicNoteLabels.Sharp;
                        break;
                    default:
                        throw new ArgumentException($"Label {label} is not valid", nameof(label));
                }
            }

            return Notes.FirstOrDefault(x => x.Name == natural && x.Label == noteLabel);
        }
    }

    public sealed class NoteLabel
    {
        public int Offset { get; }
        public string Label { get; }

        internal NoteLabel(int offset, string label)
        {
            Offset = offset;
            Label = label;
        }
    }
}
