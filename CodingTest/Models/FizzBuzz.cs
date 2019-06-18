using System.Collections.Generic;
using System.Globalization;

namespace CodingTest.Models
{
    public static class FizzBuzz
    {
        /// <summary>
        ///     Produces an increasing sequence of number strings starting with "1" but replaces the number with "Fizz",
        ///     "Buzz", or "FizzBuzz" if the number in the sequence is a multiple of three, five, or both respectively.
        ///     The sequence is terminated at integer MaxValue - 1.
        /// </summary>
        /// <returns>Enumerable sequence of strings.</returns>
        public static IEnumerable<string> Sequence()
        {
            var index = 1;
            while (index < int.MaxValue)
            {
                if (index % 3 == 0)
                {
                    yield return index % 5 == 0 ? "FizzBuzz" : "Fizz";
                }
                else
                {
                    yield return index % 5 == 0 ? "Buzz" : index.ToString(CultureInfo.InvariantCulture);
                }

                index++;
            }
        }
    }
}