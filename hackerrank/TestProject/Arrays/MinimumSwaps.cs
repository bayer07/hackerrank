namespace TestProject.Arrays
{
    internal class MinimumSwaps2
    {
        static int minimumSwaps(int[] arr)
        {
            int i = 0;
            int swap = 0;
            while (i < arr.Length)
            {
                if (arr[i] == i + 1)
                {
                    i++;
                }
                else
                {
                    int index = arr[i] - 1;
                    (arr[i], arr[index]) = (arr[index], arr[i]);
                    swap++;
                }
            }

            return swap;
        }

        [TestCaseSource(nameof(Input))]
        public void RunTest(int[] a, int expected)
        {
            int actual = minimumSwaps(a);
            Assert.AreEqual(expected, actual);
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                new [] { 7, 1, 3, 2, 4, 5, 6 }, 5
            },
            new object[]
            {
                new [] { 4, 3, 1, 2 }, 3
            },
            new object[]
            {
                new [] { 2, 3, 4, 1, 5 }, 3
            },
            new object[]
            {
                new [] { 1, 3, 5, 2, 4, 6, 7 }, 3
            }
        };
    }

}
