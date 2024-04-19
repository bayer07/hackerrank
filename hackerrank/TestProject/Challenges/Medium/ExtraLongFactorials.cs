using System.Numerics;

namespace TestProject.Challenges.Medium
{
    public class ExtraLongFactorials
    {
        public static BigInteger extraLongFactorials(int n)
        {
            var fact = (BigInteger)n;
            for (int i = n - 1; i > 0; i--)
            {
                fact *= (BigInteger)i;
            }

            return fact;
        }

        [TestCase(16, "20922789888000")]
        [TestCase(20, "2432902008176640000")]
        [TestCase(21, "51090942171709440000")]
        [TestCase(22, "1124000727777607680000")]
        [TestCase(25, "15511210043330985984000000")]
        [TestCase(45, "119622220865480194561963161495657715064383733760000000000")]
        public static void TestCase(int n, string expected)
        {
            BigInteger fact = extraLongFactorials(n);
            Assert.AreEqual(BigInteger.Parse(expected), fact);
        }
    }
}
