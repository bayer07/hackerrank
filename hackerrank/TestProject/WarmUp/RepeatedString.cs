namespace TestProject.WarmUp
{
    internal class RepeatedString
    {
        public static long repeatedString(string s, long n)
        {
            long a = n / s.Length;
            string c = s.Substring(0, (int)(n - a * s.Length));
            return s.Count(x => x == 'a') * a + c.Count(x => x == 'a');
        }

        [TestCaseSource(nameof(Input))]
        public void RunTest(string s, long n, long output)
        {
            long actual = repeatedString(s, n);
            Assert.That(actual, Is.EqualTo(output));
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                "abcac", 10L, 4L
            },
            new object[]
            {
                "aba", 10L, 7L
            },
            new object[]
            {
                "a", 1000000000000L, 1000000000000L
            }
        };
    }
}
