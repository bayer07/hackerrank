namespace TestProject.Sorting
{
    internal class BigSorting
    {
        [TestCaseSource(nameof(Input))]
        public void Sort(List<string> unsorted, List<string> expected)
        {
            var sorted = Sort(unsorted);
            Assert.That(sorted, Is.EqualTo(expected));
        }

        public static List<string> Sort(List<string> unsorted)
        {
            for (int i = 0; i < unsorted.Count; i++)
            {
                var num = double.Parse(unsorted[i]);
                for (int j = i + 1; j < unsorted.Count; j++)
                {
                    var num2 = double.Parse(unsorted[j]);
                    if (num > num2)
                    {
                        string numText = unsorted[i];
                        unsorted[i] = unsorted[j];
                        unsorted[j] = numText;
                        num = num2;
                    }
                }
            }
            return unsorted;
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                new List<string>{ "6","31415926535897932384626433832795","1","3","10","3", "5" },
                new List<string>{ "1","3","3","5","10", "31415926535897932384626433832795" }
            }
        };
    }
}
