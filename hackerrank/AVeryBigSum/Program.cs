namespace AVeryBigSum;

class Result
{
    public static long aVeryBigSum(List<long> ar)
    {
        return ar.Sum();
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

        long result = Result.aVeryBigSum(ar);
    }
}