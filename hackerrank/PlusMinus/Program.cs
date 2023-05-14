namespace PlusMinus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };

            Result.plusMinus(arr);
        }
    }

    class Result
    {
        public static void plusMinus(List<int> arr)
        {
            int n = arr.Count, positive = 0, negative = 0, zeros = 0;
            for (int i = 0; i < n; i++)
            {
                switch (arr[i])
                {
                    case < 0:
                        negative++;
                        break;
                    case > 0:
                        positive++;
                        break;
                    default:
                        zeros++;
                        break;
                }
            }
            float proportionPositive = (float)positive / n;
            float proportionNegrative = (float)negative / n;
            float proportionZeros = (float)zeros / n;
            Console.WriteLine(proportionPositive.ToString("F6"));
            Console.WriteLine(proportionNegrative.ToString("F6"));
            Console.WriteLine(proportionZeros.ToString("F6"));
        }
    }
}