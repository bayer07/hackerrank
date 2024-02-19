using TestProject.Extensions;

namespace TestProject.Sorting
{
    internal class CorrectnessInvariant
    {
        [TestCaseSource(nameof(Input))]
        public void InsertionSort(int n, List<int> arr, List<string> expected)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        (arr[j], arr[i]) = (arr[i], arr[j]);
                    }
                }
            }

            string actualResult = arr.ToLineString();
            TestContext.Out.WriteLine(actualResult);
            Assert.That(actualResult, Is.EqualTo(expected[0]));
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                4,
                new List<int> { 4, 3, 2, 1 },
                new List<string>
                {
                    "1 2 3 4"
                }
            },
            new object[]
            {
                6,
                new List<int> { 7, 4, 3, 5, 6, 2 },
                new List<string>
                {
                    "2 3 4 5 6 7"
                }
            }
        };
    }
}
