using PriyankaAndToys;

namespace TestProject
{
    public class PriyankaAndToysTest
    {
        [TestCase("1 2 3 4 5 10 11 12 13", 2)]
        [TestCase("1 2 3 21 7 12 14 21", 4)]
        [TestCase("12 15 7 8 19 24", 4)]
        [TestCase("16 18 10 13 2 9 17 17 0 19", 3)]
        public void ToysTest(string input, int expected)
        {
            List<int> w = input.TrimEnd().Split(' ').ToList().Select(wTemp => Convert.ToInt32(wTemp)).ToList();
            int actual = Result.Toys(w);
            Assert.AreEqual(expected, actual);
        }
    }
}
