namespace DiagonalDifference
{
    class Result
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int a = 0, b = 0, n = arr.Count;
            for (int i = 0; i < n; i++)
            {
                a += arr[i][i];
                b += arr[n - i - 1][i];
            }
            return Math.Abs(a - b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>() {
                new List<int> { 11, 2, 4 },
                new List<int> { 4, 5, 6 } ,
                new List<int> { 10, 8, -12 } };
            int result = Result.diagonalDifference(arr);
        }
    }
}