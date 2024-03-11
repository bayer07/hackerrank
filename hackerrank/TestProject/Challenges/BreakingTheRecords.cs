namespace TestProject.Challenges
{
    internal class BreakingTheRecords
    {
        public static List<int> BreakingRecords(List<int> scores)
        {
            int minimum = scores[0], maximum = scores[0], minimumBreaks = 0, maximumBreaks = 0;
            foreach (int score in scores)
            {
                if (minimum > score)
                {
                    minimum = score;
                    minimumBreaks++;
                }

                if (maximum < score)
                {
                    maximum = score;
                    maximumBreaks++;
                }
            }

            return new List<int> { maximumBreaks, minimumBreaks };
        }

        [TestCaseSource(nameof(Input))]
        public static void StartTest(List<int> scores, List<int> expected)
        {
            var result = BreakingRecords(scores);
            Assert.That(result, Is.EquivalentTo(expected));
        }

        public static object[] Input => new object[]{
            new object[]
            {
                new List<int>{ 12, 24, 10, 24 },new List<int>{ 1, 1 }
            },
            new object[]
            {
                new List<int>{10, 5, 20, 20, 4, 5, 2, 25, 1},new List<int>{2, 4}
            }
        };
    }
}
