using System.Linq;

namespace Music.Core
{
    public abstract class ScaleFamily
    {
        public string Name { get; }
        public bool[] Intervals { get; }
        public ScaleFamilyMode[] Modes { get; }

        public ScaleFamily(string name, bool[] intervals, ScaleFamilyMode[] modes)
        {
            Name = name;
            Intervals = intervals;
            Modes = modes;
        }

        public bool[] GetModeIntervals(ScaleFamilyMode mode)
        {
            var modeIntervals = new bool[Intervals.Length];
            Intervals.CopyTo(modeIntervals, 0);

            for (int i = 0; i < mode.FirstDegree; i++)
            {
                var first = modeIntervals[0];
                for (int j = 0; j < modeIntervals.Length - 1; j++)
                {
                    modeIntervals[j] = modeIntervals[j + 1];
                }
                modeIntervals[modeIntervals.Length - 1] = first;
            }

            return modeIntervals;
        }

        public bool IsSevenNoteScale => Intervals.Count(x => x) == 7;
    }

    public sealed class ScaleFamilyMode
    {
        public string Name { get; }
        public int FirstDegree { get; }

        internal ScaleFamilyMode(string name, int firstDegree)
        {
            Name = name;
            FirstDegree = firstDegree;
        }
    }
}
