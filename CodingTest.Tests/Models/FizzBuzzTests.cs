using System.Linq;
using CodingTest.Models;
using FluentAssertions;
using NUnit.Framework;

namespace CodingTest.Tests.Models
{
    public class FizzBuzzTests
    {

        [Test]
        public void FirstThreeItems()
        {
            var items = FizzBuzz.Sequence().Take(3).ToArray();
            items.Should().BeEquivalentTo("1", "2", "Fizz");
        }

        [Test]
        public void MultiplesOfThreeAreFizz()
        {
            var items = FizzBuzz.Sequence().Take(15).ToArray();
            items[3 - 1].Should().Be("Fizz");
            items[6 - 1].Should().Be("Fizz");
            items[9 - 1].Should().Be("Fizz");
            items[12 - 1].Should().Be("Fizz");
        }

        [Test]
        public void MultiplesOfFiveAreBuzz()
        {
            var items = FizzBuzz.Sequence().Take(15).ToArray();
            items[5 - 1].Should().Be("Buzz");
            items[10 - 1].Should().Be("Buzz");
        }

        [Test]
        public void MultiplesOfThreeAndFiveAreFizzBuzz()
        {
            var items = FizzBuzz.Sequence().Take(30).ToArray();
            items[15 - 1].Should().Be("FizzBuzz");
            items[30 - 1].Should().Be("FizzBuzz");
        }
    }
}