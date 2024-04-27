using System.Text;

namespace TestProject.Challenges.Easy
{
    internal class HackerRankInAString
    {
        [TestCase("haacckkerrannk", "YES")]
        [TestCase("haacckkerannk", "NO")]
        [TestCase("hccaakkerrannkk", "NO")]
        [TestCase("hereiamstackerrank", "YES")]
        [TestCase("hackerworld", "NO")]
        [TestCase("hhaacckkekraraannk", "YES")]
        [TestCase("rhbaasdndfsdskgbfefdbrsdfhuyatrjtcrtyytktjjt", "NO")]
        public void Test(string input, string output)
        {
            string result = HackerRankInString(input);
            Assert.That(result, Is.EqualTo(output));
        }

        string HackerRankInString(string s)
        {
            var arr = new char[10] { 'h', 'a', 'c', 'k', 'e', 'r', 'r', 'a', 'n', 'k' };
            int j = 0;
            for (int i = 0; i < s?.Length - 1; i++)
            {
                char c = s[i], b = arr[j];
                if (c == b && j < 9)
                    j++;
            }

            return j == 9 ? "YES" : "NO";
        }

        [Test]
        public void Test()
        {
            int n;
            string[] result;
            using (var fileStream = File.OpenRead("../../../Challenges/Easy/input01.txt"))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
                {
                    n = int.Parse(streamReader.ReadLine());
                    result = new string[n];
                    for (int i = 0; i < n; i++)
                    {
                        string s = streamReader.ReadLine();
                        string a = HackerRankInString(s);
                        result[i] = a;
                    }
                }
            }

            using (var fileStream = File.OpenRead("../../../Challenges/Easy/output01.txt"))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
                {
                    for (int i = 0; i < n; i++)
                    {
                        string expected = streamReader.ReadLine();
                        Assert.AreEqual(expected, result[i]);
                    }
                }
            }


        }
    }
}
