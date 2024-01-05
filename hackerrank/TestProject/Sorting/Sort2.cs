using TestProject.Extensions;

namespace TestProject.Sorting
{
    internal class Sort2
    {

        [TestCaseSource(nameof(Input))]
        public void InsertionSort2(int n, List<int> arr, List<string> expected)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (arr[j - 1] > arr[j])
                        {
                            (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                        }
                    }
                }

                string actualResult = arr.ToLineString();
                TestContext.Out.WriteLine(actualResult);
                Assert.That(actualResult, Is.EqualTo(expected[i]));
            }
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                6,
                new List<int> { 1, 4, 3, 5, 6, 2 },
                new List<string>
                {
                    "1 4 3 5 6 2",
                    "1 3 4 5 6 2",
                    "1 3 4 5 6 2",
                    "1 3 4 5 6 2",
                    "1 2 3 4 5 6"
                }
            },
            new object[]
            {
                7,
                new List<int> { 3, 4, 7, 5, 6, 2, 1 },
                new List<string>
                {
                    "3 4 7 5 6 2 1",
                    "3 4 7 5 6 2 1",
                    "3 4 5 7 6 2 1",
                    "3 4 5 6 7 2 1",
                    "2 3 4 5 6 7 1",
                    "1 2 3 4 5 6 7"
                }
            }
        };
    }
}
