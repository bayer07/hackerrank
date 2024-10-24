using System.Text;

namespace TestProject.Arrays
{
    public class NewYearChaos
    {
        public static void minimumBribes(List<int> q)
        {
            var bribeCounter = new Dictionary<int, int>();
            var originalLine = new Dictionary<int, int>();
            for (int i = 0; i < q.Count; i++)
            {
                originalLine.Add(i, q[i]);
                bribeCounter.Add(i, 0);
            }

            for (int i = q.Count - 1; i >= 0; i--)
            {
                int a = originalLine[i];
                if (a > i + 1)
                {
                    for (int j = a - 1; j < q.Count; j++)
                    {
                        int b = originalLine[j];
                        if (a > b)
                        {
                            for (int x = i; x < j; x++)
                            {
                                originalLine[x] = originalLine[x + 1];
                                originalLine[x + 1] = a;
                                bribeCounter[j]++;
                            }

                            break;
                        }
                    }

                    i++;
                }
            }

            if (bribeCounter.Any(x => x.Value > 2))
                Console.Write("Too chaotic" + Environment.NewLine);
            else
                Console.Write(bribeCounter.Sum(x => x.Value) + Environment.NewLine);
        }

        [TestCaseSource(nameof(Input))]
        public void RunTest(List<int> a, string expected)
        {
            using StringWriter sw = new();
            Console.SetOut(sw);
            minimumBribes(a);
            Assert.AreEqual(expected + Environment.NewLine, sw.ToString());
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                new List<int> { 1, 2, 3, 5, 4, 6, 7, 8 }, "1"
            },
            new object[]
            {
                new List<int> { 4, 1, 2, 3 }, "Too chaotic"
            },
            new object[]
            {
                new List<int> { 1, 3, 2 }, "1"
            },
            new object[]
            {
                new List<int> { 3, 2, 1 }, "3"
            },
            new object[]
            {
                new List<int> { 2, 1, 5, 3, 4 }, "3"
            },
            new object[]
            {
                new List<int> { 2, 5, 1, 3, 4 }, "Too chaotic"
            },
            new object[]
            {
                new List<int> { 1, 2, 5, 3, 4, 7, 8, 6 }, "4",
            },
            new object[]
            {
                new List<int> { 1, 2, 5, 3, 7, 8, 6, 4 }, "7"
            }
        };

        [Test]
        public void Test()
        {
            int t;
            List<int>[] result;
            using (var fileStream = File.OpenRead("../../../Arrays/input06.txt"))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
                {
                    t = int.Parse(streamReader.ReadLine());

                    result = new List<int>[t];
                    for (int i = 0; i < t; i++)
                    {
                        int n = int.Parse(streamReader.ReadLine());
                        result[i] = streamReader.ReadLine().Split(' ').Select(int.Parse).ToList();
                    }
                }
            }

            using (var fileStream = File.OpenRead("../../../Arrays/output06.txt"))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
                {
                    for (int i = 0; i < t; i++)
                    {
                        string expected = streamReader.ReadLine();
                        RunTest(result[i], expected);
                    }
                }
            }
        }
    }
}
