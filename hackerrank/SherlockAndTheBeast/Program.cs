namespace SherlockAndTheBeast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                Result.DecentNumber(n);
            }
        }
    }

    public class Result
    {
        public static string DecentNumber(int n)
        {
            int r3 = n / 3;
            for (int i = r3; i > 0; i--)
            {
                int x = (n - i * 3) % 5;
                if (x == 0)
                {
                    int y = n - i * 3;
                    return $"{new string('5', n - y)}{new string('3', y)}";
                }
            }

            int r2 = n / 5;
            for (int i = r2; i > 0; i--)
            {
                int x = (n - i * 5) % 3;
                if (x == 0)
                {
                    int y = n - i * 5;
                    return $"{new string('5', y)}{new string('3', n - y)}";
                }
            }

            return "-1";
        }
    }
}