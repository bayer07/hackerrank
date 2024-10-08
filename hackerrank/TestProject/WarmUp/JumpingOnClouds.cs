using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.WarmUp
{
    internal class JumpingOnClouds
    {
        public static int jumpingOnClouds(List<int> c)
        {
            int result = 0;
            while (c.Count > 1)
            {
                if (c.Count > 2 && c[2] == 0)
                    c.RemoveAt(1);
                c.RemoveAt(0);
                result++;
            }

            return result;
        }

        [TestCaseSource(nameof(Input))]
        public void Sort(List<int> input, int output)
        {
            int actual = jumpingOnClouds(input);
            Assert.That(actual, Is.EqualTo(output));
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                new List<int> { 0, 1, 0, 0, 0, 1, 0 }, 3
            },
            new object[]
            {
                new List<int> { 0, 0, 1, 0, 0, 1, 0 }, 4
            },
            new object[]
            {
                new List<int> { 0, 0, 0, 0, 1, 0 }, 3
            },
            new object[]
            {
                new List<int> { 0, 0, 0, 1, 0, 0 }, 3
            }
        };
    }
}
