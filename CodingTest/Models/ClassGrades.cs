using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CodingTest.Models
{
    public sealed class ClassGrades
    {
        public ClassGrades(IEnumerable<StudentGrade> grades)
        {
            OrderedStudentGrades = new ReadOnlyCollection<StudentGrade>(
                grades
                    .OrderByDescending(sg => sg.NumberGrade)
                    .ToList()
                    .AsReadOnly());

            AverageGrade = OrderedStudentGrades.Average(sg => sg.NumberGrade);

            // Since grades are in order we could optimize this grouping.
            CountsByGradeLetter = OrderedStudentGrades
                                  .GroupBy(sg => sg.LetterGrade.ToUpper())
                                  .Select(g => (g.Key, g.Count()));
        }

        public double AverageGrade { get; }

        public IEnumerable<(string, int)> CountsByGradeLetter { get; }

        public IReadOnlyCollection<StudentGrade> OrderedStudentGrades { get; }
    }
}