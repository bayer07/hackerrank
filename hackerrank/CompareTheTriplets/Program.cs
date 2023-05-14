namespace CompareTheTriplets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = Result.compareTriplets(a, b);
        }
    }

    class Result
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int ra = 0, rb = 0;
            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i]) ra++;
                if (b[i] > a[i]) rb++;
            }
            return new List<int>() { ra, rb };
        }
    }
}