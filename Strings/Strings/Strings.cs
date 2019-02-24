using System;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            var n = new int[20];

            string[] digits = { "null", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var num = 2540;

            Console.WriteLine("Digit = {0}",num);

            Console.WriteLine("Digits of words: ");

            var numdigit = 0;

            do
            {
                var nextdigits = num % 10;
                n[numdigit] = nextdigits;
                numdigit++;
                num = num / 10;
            } while (num > 0);
            numdigit--;

            for (; numdigit >= 0; numdigit--)
            {
                Console.Write(digits[n[numdigit]]+ " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}