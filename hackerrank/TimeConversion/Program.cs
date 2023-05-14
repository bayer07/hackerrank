namespace TimeConversion;

internal class Program
{
    static void Main(string[] args)
    {
        string result = Result.timeConversion("07:05:45PM");
        Console.WriteLine(result);
    }
}

class Result
{
    public static string timeConversion(string s)
    {
        DateTime d = DateTime.Parse(s);
        string r = d.ToString("HH:mm:ss");
        return r;
    }
}