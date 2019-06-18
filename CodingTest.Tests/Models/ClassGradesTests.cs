using CodingTest.Models;
using FluentAssertions;
using NUnit.Framework;

namespace CodingTest.Tests.Models
{
    public class ClassGradesTests
    {
        [Test]
        public void DeterminesAveragesGrade()
        {
            var g1 = new StudentGrade
            {
                FirstName = "Imma",
                LastName = "Avoro",
                LetterGrade = "A",
                NumberGrade = 100
            };

            var g2 = new StudentGrade
            {
                FirstName = "Erin",
                LastName = "Bendor",
                LetterGrade = "B",
                NumberGrade = 86
            };

            var g3 = new StudentGrade
            {
                FirstName = "Jim",
                LastName = "Carlos",
                LetterGrade = "C",
                NumberGrade = 72
            };

            var grades = new ClassGrades(new[] {g1, g2, g3});
            grades.AverageGrade.Should().Be(86);
        }

        [Test]
        public void CountByGradeLetter()
        {
            var g1 = new StudentGrade
            {
                FirstName = "Imma",
                LastName = "Avoro",
                LetterGrade = "A",
                NumberGrade = 100
            };

            var g2 = new StudentGrade
            {
                FirstName = "Erin",
                LastName = "Bendor",
                LetterGrade = "B",
                NumberGrade = 86
            };

            var g3 = new StudentGrade
            {
                FirstName = "Kelly",
                LastName = "Jones",
                LetterGrade = "C",
                NumberGrade = 76
            };

            var g4 = new StudentGrade
            {
                FirstName = "Joe",
                LastName = "Smith",
                LetterGrade = "B",
                NumberGrade = 84
            };

            var grades = new ClassGrades(new[] { g1, g2, g3, g4 });
            grades.CountsByGradeLetter.Should().BeEquivalentTo(new []{("A",1), ("B", 2), ("C", 1)});
        }

        [Test]
        public void OrderedByGrade()
        {
            var g1 = new StudentGrade
            {
                FirstName = "Imma",
                LastName = "Avoro",
                LetterGrade = "A",
                NumberGrade = 100
            };

            var g2 = new StudentGrade
            {
                FirstName = "Erin",
                LastName = "Bendor",
                LetterGrade = "B",
                NumberGrade = 86
            };

            var g3 = new StudentGrade
            {
                FirstName = "Kelly",
                LastName = "Jones",
                LetterGrade = "C",
                NumberGrade = 76
            };

            var g4 = new StudentGrade
            {
                FirstName = "Joe",
                LastName = "Smith",
                LetterGrade = "B",
                NumberGrade = 84
            };

            var grades = new ClassGrades(new[] { g1, g2, g3, g4 });
            grades.OrderedStudentGrades.Should().BeInDescendingOrder(sg => sg.NumberGrade);
        }
    }
}