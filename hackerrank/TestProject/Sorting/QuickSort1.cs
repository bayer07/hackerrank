using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Sorting
{
    internal class QuickSort1
    {
        [TestCaseSource(nameof(Input))]
        public void Q(List<int> arr, List<int> expectedArray)
        {
            var quickSortedArray = QuickSort(arr);
            for (int i = 0; i < arr.Count; i++)
            {
                Assert.That(expectedArray[i], Is.EqualTo(quickSortedArray[i]));
            }
        }

        public List<int> QuickSort(List<int> arr)
        {
            int p = arr[0];
            var left = new List<int>();
            var right = new List<int>();
            for (int i = 1; i < arr.Count; i++)
            {
                var element = arr[i];
                if (element > p)
                    right.Add(element);
                else
                    left.Add(element);
            }

            var result = new List<int>();
            result.AddRange(left);
            result.Add(p);
            result.AddRange(right);
            return result;
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                new List<int> { 4,5,3,7,2 },
                new List<int> { 3, 2, 4, 5, 7 }
            }
        };
    }
}
