namespace TestProject.Challenges
{
    internal class TheBirthdayBar
    {
        public static int Birthday(List<int> s, int d, int m)
        {
            int result = 0;
            for (int i = 0; i < s.Count; i++)
            {
                int x = s[i];
                int sum = x;
                bool hasM = x == d;
                if (sum > d * m)
                    break;
                else if (sum == d * m && hasM)
                {
                    result++;
                    break;
                }
                else
                {
                    for (int j = i + 1; j < s.Count; j++)
                    {
                        x = s[j];
                        sum += x;
                        if (!hasM)
                        {
                            hasM = x == d;
                        }

                        if (sum == d * m && hasM)
                        {
                            result++;
                            break;
                        }
                    }
                }
            }

            return result;
        }

        [Ignore("")]
        [TestCaseSource(nameof(Input))]
        public static void StartTest(List<int> s, int d, int m, int expected)
        {
            var result = Birthday(s, d, m);
            Assert.That(result, Is.EqualTo(expected));
        }

        public static object[] Input => new object[]{
            new object[]
            {
                new List<int>{4}, 4, 1, 1
            },
            new object[]
            {
                new List<int>{1, 2, 1, 3, 2}, 3, 2, 2
            },
            new object[]
            {
                new List<int>{1, 1, 1, 1, 1, 1}, 3, 2, 0
            },
            new object[]
            {
                new List<int>{2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4, 2, 1}, 18, 7, 3
            }
        };
    }
}
