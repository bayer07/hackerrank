namespace TestProject.Challenges
{
    internal class AppleAndOrange : BaseTest
    {
        [TestCaseSource(nameof(Input))]
        public static void StartTest(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            CountApplesAndOranges(s, t, a, b, apples, oranges);
        }

        public static new object[] Input => new object[]{
            new object[]
            {
                7,10,4,12, new List<int>{2,3,-4}, new List<int>{ 3,-2,-4}
            }
        };

        public static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applesInSamsHouse = 0, orangesInSamsHouse = 0;
            foreach (var apple in apples)
            {
                int position = a + apple;
                if (position >= s && position <= t)
                {
                    applesInSamsHouse++;
                }
            }

            foreach (var orange in oranges)
            {
                int position = b + orange;
                if (position >= s && position <= t)
                {
                    orangesInSamsHouse++;
                }
            }

            Console.WriteLine(applesInSamsHouse);
            Console.WriteLine(orangesInSamsHouse);
        }
    }
}
