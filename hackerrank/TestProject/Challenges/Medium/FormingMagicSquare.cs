namespace TestProject.Challenges.Medium
{
    public class FormingMagicSquareChallende
    {
        public static int FormingMagicSquare(List<List<int>> s)
        {
            var arr = new int[8][] {
                new int[]{8, 3, 4, 1, 5, 9, 6, 7, 2},
                new int[]{6, 7, 2, 1, 5, 9, 8, 3, 4},
                new int[]{2, 7, 6, 9, 5, 1, 4, 3, 8},
                new int[]{4, 3, 8, 9, 5, 1, 2, 7, 6},
                new int[]{2, 9, 4, 7, 5, 3, 6, 1, 8},
                new int[]{6, 1, 8, 7, 5, 3, 2, 9, 4},
                new int[]{8, 1, 6, 3, 5, 7, 4, 9, 2},
                new int[]{4, 9, 2, 3, 5, 7, 8, 1, 6},
            };
            var sumMap = new Dictionary<int, int>();
            for (int i = 0; i < s.Count; i++)
            {
                for (int j = 0; j < s[i].Count; j++)
                {
                    int seq = j + i * 3;
                    for (int k = 0; k < 8; k++)
                    {
                        sumMap.TryGetValue(k, out int sum);
                        sum += Math.Abs(s[i][j] - arr[k][seq]);
                        sumMap[k] = sum;
                    }
                }
            }
            return sumMap.Min(x => x.Value);
        }

        [TestCaseSource(nameof(Input))]
        public static void StartTest(List<List<int>> s, int expected)
        {
            int result = FormingMagicSquare(s);
            Assert.That(result, Is.EqualTo(expected));
        }

        public static object[] Input => new object[]
        {
            new object[]
            {
                new List<List<int>>
                {
                    new() { 5, 3, 4 },
                    new() { 1, 5, 8 },
                    new() { 6, 4, 2 }
                },
                7
            },
            new object[]
            {
                new List<List<int>>
                {
                    new() { 4, 9, 2 },
                    new() { 3, 5, 7 },
                    new() { 8, 1, 5 }
                },
                1
            },
            new object[]
            {
                new List<List<int>>
                {
                    new() { 4, 8, 2 },
                    new() { 4, 5, 7 },
                    new() { 6, 1, 6 }
                },
                4
            },
            new object[]
            {
                new List<List<int>>
                {
                    new() { 4, 5, 8 },
                    new() { 2, 4, 1 },
                    new() { 1, 9, 7 }
                },
                14
            }
        };
    }
}
