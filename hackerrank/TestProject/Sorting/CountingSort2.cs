﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Sorting
{
    internal class CountingSort2
    {
        [TestCaseSource(nameof(Input))]
        public void Main(string input, string output)
        {
            var arr = input.Split(' ').Select(x => int.Parse(x)).ToList();
            var expected = output.Split(' ').Select(x => int.Parse(x)).ToList();
            var sortedArray = CountingSort(arr);
            for (int i = 0; i < arr.Count; i++)
            {
                Assert.That(expected[i], Is.EqualTo(sortedArray[i]));
            }
        }

        public static List<int> CountingSort(List<int> arr)
        {
            var countingArray = new int[100];
            for (int i = 0; i < arr.Count; i++)
            {
                countingArray[arr[i]]++;
            }

            var sortedArray = new List<int>();
            for (int i = 0; i < countingArray.Length; i++)
            {
                for (int j = 0; j < countingArray[i]; j++)
                {
                    sortedArray.Add(i);
                }
            }

            return sortedArray;
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                "63 25 73 1 98 73 56 84 86 57 16 83 8 25 81 56 9 53 98 67 99 12 83 89 80 91 39 86 76 85 74 39 25 90 59 10 94 32 44 3 89 30 27 79 46 96 27 32 18 21 92 69 81 40 40 34 68 78 24 87 42 69 23 41 78 22 6 90 99 89 50 30 20 1 43 3 70 95 33 46 44 9 69 48 33 60 65 16 82 67 61 32 21 79 75 75 13 87 70 33",
                "1 1 3 3 6 8 9 9 10 12 13 16 16 18 20 21 21 22 23 24 25 25 25 27 27 30 30 32 32 32 33 33 33 34 39 39 40 40 41 42 43 44 44 46 46 48 50 53 56 56 57 59 60 61 63 65 67 67 68 69 69 69 70 70 73 73 74 75 75 76 78 78 79 79 80 81 81 82 83 83 84 85 86 86 87 87 89 89 89 90 90 91 92 94 95 96 98 98 99 99"
            }
        };
    }
}
