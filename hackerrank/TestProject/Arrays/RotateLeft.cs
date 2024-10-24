using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Arrays
{
    internal class LeftRotation
    {
        public static List<int> rotLeft(List<int> a, int d)
        {
            for (int i = 0; i < d; i++)
            {
                a.Add(a[0]);
                a.RemoveAt(0);
            }

            return a;
        }

        [TestCaseSource(nameof(Input))]
        public void RunTest(List<int> a, int b, List<int> output)
        {
            var actual = rotLeft(a, b);
            Assert.That(actual, Is.EqualTo(output));
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                new List<int> { 1, 2, 3, 4, 5 }, 2, new List<int> { 3, 4, 5, 1, 2 }
            },
            new object[]
            {
                new List<int> { 1, 2, 3, 4, 5 }, 4, new List<int> { 5, 1, 2, 3, 4 }
            }
        };
    }

}
