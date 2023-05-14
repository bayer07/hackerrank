namespace Staircase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(6);

            Result.staircase(n);
            Console.ReadKey();
        }
    }

    class Result
    {
        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > 0; j--)
                {
                    Console.Write(i < j - 1 ? " " : "#");
                }

                Console.Write(Environment.NewLine);
            }
        }
    }
}