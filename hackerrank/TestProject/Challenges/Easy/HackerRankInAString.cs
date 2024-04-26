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
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == arr[j])
                    j++;
            }

            return j == 9 ? "YES" : "NO";
        }
    }
}
