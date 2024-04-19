using System.Diagnostics;
using System.Text;

namespace TestProject.Challenges.Medium
{
    public class ClimbingTheLeaderboard
    {
        public static List<int> ClimbingLeaderboard(List<int> ranked, List<int> players)
        {
            ranked = ranked.Distinct().ToList();
            int i = ranked.Count - 1, rank;
            var result = new List<int>();
            foreach (int player in players)
            {
                int place;
                rank = ranked[i];
                while (rank < player && i > 0)
                {
                    i--;
                    rank = ranked[i];
                }

                if (rank > player)
                    place = i + 2;
                else if (rank == player)
                    place = i + 1;
                else
                    place = 1;

                result.Add(place);
            }

            return result;
        }

        [TestCase]
        public static void TestFromFile()
        {
            string rankedString, playersString, output;
            using (var fileStream = File.OpenRead("..\\..\\..\\Challenges\\Medium\\input06.txt"))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
                {
                    streamReader.ReadLine();
                    rankedString = streamReader.ReadLine();
                    streamReader.ReadLine();
                    playersString = streamReader.ReadLine();
                }
            }

            var expected = new List<int>();
            using (var fileStream = File.OpenRead("..\\..\\..\\Challenges\\Medium\\output06.txt"))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
                {
                    while (!streamReader.EndOfStream)
                    {
                        output = streamReader.ReadLine();
                        int x = int.Parse(output);
                        expected.Add(x);
                    }
                }
            }

            var ranked = rankedString.Split(" ").Select(x => int.Parse(x)).ToList();
            var players = playersString.Split(" ").Select(x => int.Parse(x)).ToList();

            var sw = Stopwatch.StartNew();
            var result = ClimbingLeaderboard(ranked, players);
            sw.Stop();

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCaseSource(nameof(Input))]
        public static void StartTest(List<int> ranked, List<int> players, List<int> expected)
        {
            var sw = Stopwatch.StartNew();
            var result = ClimbingLeaderboard(ranked, players);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Assert.That(result, Is.EqualTo(expected));
        }

        public static object[] Input => new object[]
        {
            new object[]
            {
                new List<int>
                {
                     100, 90, 90, 80
                },
                new List<int>
                {
                     70, 80, 105
                },
                new List<int>
                {
                     4, 3, 1
                },
            },
            new object[]
            {
                new List<int>
                {
                     100, 100, 50, 40, 40, 20, 10
                },
                new List<int>
                {
                     5, 25, 50, 120
                },
                new List<int>
                {
                     6, 4, 2, 1
                },
            }
        };
    }
}
