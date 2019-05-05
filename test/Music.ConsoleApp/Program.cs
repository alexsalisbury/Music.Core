using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using McMaster.Extensions.CommandLineUtils;
using Music.ConsoleApp.Validation;
using Music.Core;

namespace Music.ConsoleApp
{
    class Program
    {
        [Required]
        [Option(Description = "Root note of the scale")]
        [AllowedNotes]
        public string Note { get; }

        [Required]
        [Option(Description = "Scale to be used")]
        [AllowedScales]
        public string Scale { get; }

        [Required]
        [Option(Description = "Number of frets to generate")]
        [Range(5, 24)]
        public int Frets { get; }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            CommandLineApplication.Execute<Program>(args);
        }

        private void OnExecute()
        {
            var rootNote = MusicNotes.FromString(Note);
            var scale = CreateScaleInstance(rootNote);

            var tuning = new[] { MusicNotes.E, MusicNotes.B, MusicNotes.G, MusicNotes.D, MusicNotes.A, MusicNotes.E };
            var fretboard = new Fretboard(tuning, Frets);

            fretboard.SetScale(scale);

            PrintFretboard(rootNote, scale, Frets, fretboard);
        }

        private void PrintFretboard(Note rootNote, ScaleBase scale, int numberOfFrets, Fretboard fretboard)
        {
            PrintScaleInfo(rootNote, scale);

            PrintFretNumbers(numberOfFrets);

            PrintFretboardNotes(scale, fretboard);

            PrintFretboardMarks(numberOfFrets);
        }

        private void PrintFretboardMarks(int numberOfFrets)
        {
            var fretMarks = new[] { 1, 3, 5, 7, 9 };
            Console.Write("    ");
            for (int i = 1; i <= numberOfFrets; i++)
            {
                if (fretMarks.Contains(i % 12))
                {
                    Console.Write(" ●   ");
                }
                else if (i % 12 == 0)
                {
                    Console.Write(" ●●  ");
                }
                else
                {
                    Console.Write("     ");
                }
            }
        }

        private void PrintFretboardNotes(ScaleBase scale, Fretboard fretboard)
        {
            foreach (var fretNote in fretboard.StringNotes)
            {
                WriteColor(fretNote[0].ToString().PadRight(3, ' '), GetNoteColor(fretNote[0], scale));
                Console.Write("|");
                for (int i = 1; i < fretNote.Length; i++)
                {
                    Console.Write("-");
                    var note = fretNote[i].ToString();
                    WriteColor(note, GetNoteColor(fretNote[i], scale));
                    var separator = new string('-', 3 - note.Length) + "|";
                    Console.Write(separator);
                }
                Console.WriteLine();
            }
        }

        private void PrintFretNumbers(int numberOfFrets)
        {
            Console.Write("    ");
            for (int i = 1; i <= numberOfFrets; i++)
            {
                Console.Write(" " + i.ToString().PadRight(4, ' '));
            }

            Console.WriteLine();
        }

        private void PrintScaleInfo(Note rootNote, ScaleBase scale)
        {
            Console.WriteLine($"{rootNote} {scale.Name} Scale");
            Console.Write("Notes: ");
            foreach (var note in scale.Notes)
            {
                Console.Write($"{note.Note} ");
            }

            Console.WriteLine();
        }

        private void WriteColor(string text, ConsoleColor color)
        {
            var previousColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = previousColor;
        }

        private ConsoleColor GetNoteColor(Note note, ScaleBase scale)
        {
            if (scale.Notes.Any(x => x.Note == note))
            {
                return ConsoleColor.Green;
            }

            return ConsoleColor.DarkGray;
        }

        private ScaleBase CreateScaleInstance(Note rootNote)
        {
            var scaleType = ScaleEnumerator.ScaleTypes.First(x => x.Name.ToLowerInvariant().StartsWith(Scale.ToLowerInvariant()));

            return (ScaleBase)Activator.CreateInstance(scaleType, rootNote);
        }
    }
}
