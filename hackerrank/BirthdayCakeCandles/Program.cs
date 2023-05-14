namespace BirthdayCakeCandles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int candlesCount = Convert.ToInt32(4);

            List<int> candles = "3 2 1 3".Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = Result.birthdayCakeCandles(candles);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    class Result
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.Max();
            int numberOfTallest = candles.Count(x => x == max);
            return numberOfTallest;
        }
    }
}