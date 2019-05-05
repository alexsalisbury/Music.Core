namespace Music.Core.Extensions
{
    public static class ArrayExtensions
    {
        public static T[] GetRow<T>(this T[,] matrix, int row)
        {
            var rowLength = matrix.GetLength(1);
            var rowVector = new T[rowLength];

            for (var i = 0; i < rowLength; i++)
            {
                rowVector[i] = matrix[row, i];
            }

            return rowVector;
        }
    }
}
