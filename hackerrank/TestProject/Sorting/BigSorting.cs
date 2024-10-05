using System.Diagnostics;

namespace TestProject.Sorting
{
    internal class BigSorting
    {
        [Ignore("")]
        [TestCaseSource(nameof(Input))]
        public void Sort(List<string> array, List<string> expected)
        {
            Sort(array);
            Assert.That(array, Is.EqualTo(expected));
        }

        [TestCaseSource(nameof(InputFromFile))]
        public void TestFromFile(string[] input, string[] output)
        {
            int n = int.Parse(input[0]);
            var list = new List<string>(input);
            list.RemoveAt(0);
            Sort(list);
            Assert.That(list.ToArray(), Is.EqualTo(output));
        }

        public static void Sort(List<string> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                var num = ulong.Parse(array[i]);
                for (int j = i + 1; j < array.Count; j++)
                {
                    var num2 = ulong.Parse(array[j]);
                    if (num > num2)
                    {
                        string numText = array[i];
                        array[i] = array[j];
                        array[j] = numText;
                        num = num2;
                    }
                }
            }
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                new List<string>{ "6","31415926535897932384626433832795","1","3","10","3", "5" },
                new List<string>{ "1","3","3","5","10", "31415926535897932384626433832795" }
            }
        };

        public static object[] InputFromFile()
        {
            var output = File.ReadAllLines($"{Directory.GetCurrentDirectory()}\\output02.txt");
            var input = File.ReadAllLines($"{Directory.GetCurrentDirectory()}\\input02.txt");
            return new object[] { new object[2] { input, output } };
        }
    }
}
