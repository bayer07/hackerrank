namespace Mini_MaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = "256741038 623958417 467905213 714532089 938071625".Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }

    class Result
    {
        public static void miniMaxSum(List<int> arr)
        {
            int n = arr.Count;
            var result = new List<long>();
            for (int i = 0; i < n; i++)
            {
                long sum = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                        sum += arr[j];
                }

                result.Add(sum);
            }

            Console.WriteLine($"{result.Min()} {result.Max()}");
        }
    }
}