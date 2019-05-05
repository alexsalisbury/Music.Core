using Music.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Music.Core
{
    public abstract class ScaleBase
    {
        public string Name { get; }
        public Note RootNote { get; }
        public ScaleNote[] ChromaticNotes { get; }
        public ScaleNote[] Notes { get; }
        public ScaleFamily ScaleFamily { get; }
        public ScaleFamilyMode Mode { get; }

        public ScaleBase(string name, Note rootNote, ScaleFamily scaleFamily, ScaleFamilyMode mode)
        {
            Name = name;
            RootNote = rootNote;
            ScaleFamily = scaleFamily;
            Mode = mode;

            ChromaticNotes = GetChromaticNotes();

            Notes = ChromaticNotes.Where(x => x.IsPresent).ToArray();
        }

        private static Note[] GetScaleNaturals(int startIndex)
        {
            var notes = new List<Note>();

            for (int i = 0; i < MusicNotes.NaturalNotes.Length; i++)
            {
                notes.Add(MusicNotes.NaturalNotes[(i + startIndex) % MusicNotes.NaturalNotes.Length]);
            }

            return notes.ToArray();
        }

        private ScaleNote[] GetChromaticNotes()
        {
            var naturalNote = RootNote.Natural != null ? RootNote.Natural : RootNote;
            var naturalIndex = Array.IndexOf(MusicNotes.NaturalNotes, naturalNote);
            var naturalNotes = GetScaleNaturals(naturalIndex);
            var intervals = ScaleFamily.GetModeIntervals(Mode);
            var noteCount = intervals.Count(x => x);

            var noteIndex = 0;
            IntervalTableItem interval;

            var notes = new List<ScaleNote>();
            for (int i = 0; i < 12; i++)
            {
                var isIntervalPresent = intervals[i];
                if (isIntervalPresent && ScaleFamily.IsSevenNoteScale)
                {
                    interval = Intervals.IntervalTable.GetRow(i).First(x => x.ScaleDegree == noteIndex);
                    noteIndex = (noteIndex + 1) % noteCount;
                }
                else
                {
                    interval = Intervals.IntervalTable.GetRow(i)[0];
                }

                naturalNote = naturalNotes[interval.ScaleDegree];

                var index = (RootNote.Index + i) % 12;
                var note = MusicNotes.Notes.First(x => x.Name == naturalNote.Name && x.Index == index);

                var scaleNote = new ScaleNote(this, note, i, isIntervalPresent, interval);

                notes.Add(scaleNote);
            }

            return notes.ToArray();
        }
    }

    public sealed class ScaleNote
    {
        public ScaleBase Scale { get; }
        public Note Note { get; }
        public int ScaleDegree { get; }
        public bool IsPresent { get; }
        public IntervalTableItem Interval { get; }

        internal ScaleNote(ScaleBase scale, Note note, int degree, bool isPresent, IntervalTableItem intervalTable)
        {
            Scale = scale;
            Note = note;
            ScaleDegree = degree;
            IsPresent = isPresent;
            Interval = intervalTable;
        }

        public override string ToString() => Note.ToString();
    }
}