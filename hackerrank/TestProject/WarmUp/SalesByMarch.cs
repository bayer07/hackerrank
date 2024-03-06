using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.WarmUp
{
    public class SalesByMarch
    {
        [TestCaseSource(nameof(Input))]

        public static void SockMerchant(int n, List<int> ar, int expected)
        {
            int count = Count(n, ar);
            Assert.That(expected, Is.EqualTo(count));
        }

        public static int Count(int n, List<int> ar)
        {
            var array = new int[101];
            for (int i = 0; i < n; i++)
            {
                int x = ar[i];
                array[x]++;
            }

            return array.Sum(x => x / 2);
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                1,
                new List<int>{ 100 },
                0
            }
        };
    }
}
