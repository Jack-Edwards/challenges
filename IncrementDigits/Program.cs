using System;

namespace Challenge
{
    class Solution
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter an integer: ");
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine(IncrementDigits(value));
            }

        }

        /// <summary>  
        ///     Add 1 to every digit in the passed in "number"
        /// </summary>
        /// <param name="number">
        ///     An integer
        /// </param>
        private static int IncrementDigits(int number)
        {
            if (number < 10)
            {
                return number + 1;
            }

            int incrementedQuotient = IncrementDigits(number / 10);
            int incrementedRemainder = (number % 10) + 1;

            int multiplier = incrementedRemainder == 10 ? 100 : 10;
            return (incrementedQuotient * multiplier) + incrementedRemainder;
        }
    }
}