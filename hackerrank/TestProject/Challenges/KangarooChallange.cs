namespace TestProject.Challenges
{
    internal class KangarooChallange
    {
        public static object[] Input => new object[]{
            new object[]
            {
                2,1,1,2, "YES"
            },
            new object[]
            {
                0,3,4,2, "YES"
            },
            new object[]
            {
                4523, 8092, 9419, 8076, "YES"
            }
        };

        [TestCaseSource(nameof(Input))]
        public static void StartTest(int x1, int v1, int x2, int v2, string expected)
        {
            string result = Kangaroo(x1, v1, x2, v2);
            Assert.That(result, Is.SameAs(expected));
        }

        private static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            bool comparsion = x1 > x2;
            bool oldValue = x1 > x2;
            while (comparsion == oldValue)
            {
                if (x1 == x2)
                    return "YES";

                x1 += v1;
                x2 += v2;
                comparsion = x1 > x2;
            }

            return "NO";
        }
    }
}
