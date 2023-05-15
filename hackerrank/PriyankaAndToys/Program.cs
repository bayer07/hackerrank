namespace PriyankaAndToys
{
    public class Result
    {
        public static int Toys(List<int> w)
        {
            int containersCount = 0;
            while (w.Any())
            {
                int minimumWeight = w[0];
                for (int i = 1; i < w.Count; i++)
                {
                    if (w[i] < minimumWeight)
                    {
                        minimumWeight = w[i];
                    }
                }

                int maximumWeight = minimumWeight + 4;
                for (int i = w.Count - 1; i > -1; i--)
                {
                    var weight = w[i];
                    if (weight >= minimumWeight && weight <= maximumWeight)
                    {
                        w.RemoveAt(i);
                    }
                }

                containersCount++;
            }

            return containersCount;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> w = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(wTemp => Convert.ToInt32(wTemp)).ToList();

            int result = Result.Toys(w);
        }
    }
}