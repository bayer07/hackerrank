namespace TestProject.Challenges
{
    internal class BetweenTwoSets
    {
        public static int GetTotalX(List<int> a, List<int> b)
        {
            int n = a.Last();
            int m = b.First();
            int count = 0;
            for (int i = n; i <= m; i++)
            {
                bool isFactor = true;
                foreach (int x in a)
                {
                    if (x % i != 0 && i % x != 0)
                    {
                        isFactor = false;
                        break;
                    }
                }

                foreach (int x in b)
                {
                    if (x % i != 0 && i % x != 0)
                    {
                        isFactor = false;
                        break;
                    }
                }

                if (isFactor)
                    count++;
            }

            return count;
        }

        [TestCaseSource(nameof(Input))]
        public static void StartTest(List<int> a, List<int> b, int expected)
        {
            var result = GetTotalX(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        public static object[] Input => new object[]{
            new object[]
            {
                new List<int>{2,6},new List<int>{24,36}, 2
            },
            new object[]
            {
                new List<int>{2, 4},new List<int>{16, 32, 96}, 3
            }
        };
    }
}
