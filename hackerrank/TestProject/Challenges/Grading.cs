using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Challenges
{
    internal class Grading
    {
        public static List<int> GradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                int grade = grades[i];
                if (grade >= 38)
                {
                    int dif = 5 - grade % 5;
                    if (dif < 3)
                    {
                        grades[i] = grade + dif;
                    }
                }
            }

            return grades;
        }

        [TestCaseSource(nameof(Input))]
        public static void StartTest(List<int> input, List<int> output)
        {
            var grades = GradingStudents(input);
            Assert.That(grades, Is.EquivalentTo(output));
        }

        public static readonly object[] Input =
        {
            new object[]
            {
                new List<int>{ 73,67,38,33 },
                new List<int>{ 75,67,40,33 }
            }
        };
    }
}
