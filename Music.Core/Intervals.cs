namespace Music.Core
{
    public static class Intervals
    {

        public static readonly IntervalTableItem[,] IntervalTable = new IntervalTableItem[12, 2]
        {
            { new IntervalTableItem(0, 0, IntervalQuality.P1), new IntervalTableItem(0, 1, IntervalQuality.d2) },
            { new IntervalTableItem(1, 1, IntervalQuality.m2), new IntervalTableItem(1 ,0, IntervalQuality.A1) },
            { new IntervalTableItem(2, 1, IntervalQuality.M2), new IntervalTableItem(2, 2, IntervalQuality.d3) },
            { new IntervalTableItem(3, 2, IntervalQuality.m3), new IntervalTableItem(3, 1, IntervalQuality.A2) },
            { new IntervalTableItem(4, 2, IntervalQuality.M3), new IntervalTableItem(4, 3, IntervalQuality.d4) },
            { new IntervalTableItem(5, 3, IntervalQuality.P4), new IntervalTableItem(5, 2, IntervalQuality.A3) },
            { new IntervalTableItem(6, 4, IntervalQuality.d5), new IntervalTableItem(6, 3, IntervalQuality.A4) },
            { new IntervalTableItem(7, 4, IntervalQuality.P5), new IntervalTableItem(7, 5, IntervalQuality.d6) },
            { new IntervalTableItem(8, 5, IntervalQuality.m6), new IntervalTableItem(8, 4, IntervalQuality.A5) },
            { new IntervalTableItem(9, 5, IntervalQuality.M6), new IntervalTableItem(9, 6, IntervalQuality.d7) },
            { new IntervalTableItem(10, 6, IntervalQuality.m7), new IntervalTableItem(10, 5, IntervalQuality.A6) },
            { new IntervalTableItem(11, 6, IntervalQuality.M7), new IntervalTableItem(0, 0, IntervalQuality.A7) }
         };
    }

    public sealed class IntervalTableItem
    {
        public int ChromaticDegree { get; }
        public int ScaleDegree { get; }
        public IntervalQuality IntervalQuality { get; }

        internal IntervalTableItem(int chromaticDegree, int scaleDegree, IntervalQuality intervalType)
        {
            ChromaticDegree = chromaticDegree;
            ScaleDegree = scaleDegree;
            IntervalQuality = intervalType;
        }
    }

    public enum IntervalQuality
    {
        P1,
        M2,
        M3,
        P4,
        P5,
        M6,
        M7,
        m2,
        m3,
        m6,
        m7,
        d2,
        d3,
        d4,
        d5,
        d6,
        d7,
        A1,
        A2,
        A3,
        A4,
        A5,
        A6,
        A7
    }
}
