using TestProject.Extensions;

namespace TestProject.Sorting
{
    internal class Sort1
    {

        [TestCaseSource(nameof(Input))]
        public void InsertionSort1(int n, List<int> arr, List<string> expected)
        {
            int expectedIndex = 0;
            for (int i = n - 1; i > 0; i--)
            {
                int x = arr[i];
                if (x < arr[i - 1])
                {
                    for (int j = i - 1; j > -1; j--)
                    {
                        if (arr[j] > x)
                        {
                            arr[j + 1] = arr[j];

                            string actualResult = arr.ToLineString();
                            TestContext.Out.WriteLine(actualResult);
                            Assert.AreEqual(expected[expectedIndex], actualResult);
                            expectedIndex++;
                        }
                        else
                        {
                            arr[j + 1] = x;

                            string actualResult = arr.ToLineString();
                            TestContext.Out.WriteLine(actualResult);
                            Assert.AreEqual(expected[expectedIndex], actualResult);
                            expectedIndex++;

                            break;
                        }
                    }

                    if (arr[0] > x)
                    {
                        arr[0] = x;

                        string actualResult = arr.ToLineString();
                        TestContext.Out.WriteLine(actualResult);
                        Assert.AreEqual(expected[expectedIndex], actualResult);
                        expectedIndex++;
                    }
                }
            }
            Assert.AreEqual(expected.Count, expectedIndex);
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                5,
                new List<int> { 2, 4, 6, 8, 3 },
                new List<string>
                {
                    "2 4 6 8 8",
                    "2 4 6 6 8",
                    "2 4 4 6 8",
                    "2 3 4 6 8"
                }
            },
            new object[]
            {
                10,
                new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 },
                new List<string>
                {
                    "2 3 4 5 6 7 8 9 10 10",
                    "2 3 4 5 6 7 8 9 9 10",
                    "2 3 4 5 6 7 8 8 9 10",
                    "2 3 4 5 6 7 7 8 9 10",
                    "2 3 4 5 6 6 7 8 9 10",
                    "2 3 4 5 5 6 7 8 9 10",
                    "2 3 4 4 5 6 7 8 9 10",
                    "2 3 3 4 5 6 7 8 9 10",
                    "2 2 3 4 5 6 7 8 9 10",
                    "1 2 3 4 5 6 7 8 9 10"
                }
            }
        };
    }
}
