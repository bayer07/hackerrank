namespace TestProject.warmup
{
    internal class CountingValleys
    {
        public static int countingValleys(int steps, string path)
        {
            int valleys = 0, level = 0;
            foreach (char c in path)
            {
                switch (c)
                {
                    case 'D':
                        if (level == 0)
                            valleys++;

                        level--;
                        break;
                    case 'U':
                        level++;
                        break;
                }
            }

            return valleys;
        }

        [TestCaseSource(nameof(Input))]
        public void Sort(int steps, string path, int expected)
        {
            int actual = countingValleys(steps, path);
            Assert.That(actual, Is.EqualTo(expected));
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                8, "DDUUUUDD", 1
            },
            new object[]
            {
                8, "UDDDUDUU", 1
            },
            new object[]
            {
                12, "DDUUDDUDUUUD", 2
            },
            new object[]
            {
                10, "UDUUUDUDDD", 0
            }
        };
    }
}
