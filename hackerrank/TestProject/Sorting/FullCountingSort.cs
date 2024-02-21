using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Sorting
{
    internal class FullCountingSort
    {
        [TestCaseSource(nameof(Input))]
        public void CountingSort(List<List<string>> arr, string expected)
        {
            _expected = expected;
            CountingSort(arr);
        }

        private string _expected;
        public void CountingSort(List<List<string>> arr)
        {
            var countingArray = new List<List<string>>();
            for (int i = 0; i < arr.Count; i++)
            {
                countingArray.Add(new List<string>());
            }

            int m = arr.Count / 2;
            for (int i = 0; i < arr.Count; i++)
            {
                int number = int.Parse(arr[i][0]);
                var text = arr[i][1];
                if (i < m)
                    countingArray[number].Add("-");
                else
                    countingArray[number].Add(text);
            }

            var result = string.Join(' ', countingArray.Where(x => x.Count > 0).Select(x => string.Join(' ', x)));

            Console.WriteLine(result);
            Assert.AreEqual(_expected, result);
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                new List<List<string>>
                {
                    new List<string>{ "0","ab" },
                    new List<string>{"6","cd" },
                    new List<string>{"0","ef" },
                    new List<string>{ "6","gh"},
                    new List<string>{"4","ij" },
                    new List<string>{ "0","ab"},
                    new List<string>{ "6","cd"},
                    new List<string>{"0","ef" },
                    new List<string>{ "6","gh"},
                    new List<string>{ "0","ij"},
                    new List<string>{"4","that" },
                    new List<string>{ "3","be"},
                    new List<string>{ "0","to"},
                    new List<string>{ "1","be"},
                    new List<string>{ "5","question"},
                    new List<string>{ "1","or"},
                    new List<string>{ "2","not"},
                    new List<string>{ "4","is"},
                    new List<string>{ "2","to"},
                    new List<string>{"4","the" },
                },
                "- - - - - to be or not to be - that is the question - - - -"
            },
            new object[]
            {
                new List<List<string>>
                {
                    new List<string>{ "1", "e" },
                    new List<string>{ "2", "a" },
                    new List<string>{ "2", "a" },
                    new List<string>{ "1", "b" },
                    new List<string>{ "3", "a" },
                    new List<string>{ "1", "f" },
                    new List<string>{ "2", "a" },
                    new List<string>{ "1", "e" },
                    new List<string>{ "1", "b" },
                    new List<string>{ "1", "c" },
                },
                "- - f e b c - a - -"
            }
        };
    }
}
