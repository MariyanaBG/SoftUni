using System;

namespace _01.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method that prints the sign of an integer number n:
            //    2   =>  The number 2 is positive.
            //    - 5 =>  The number -5 is negative.
            //    0   =>  The number 0 is zero.

            int number = int.Parse(Console.ReadLine());
            PrintIntegerSign(number);

        }

        static void PrintIntegerSign(int number)
        {
            string result = string.Empty;
            if (number > 0)
            {
                result = "positive";
            }
            else if (number < 0)
            {
                result = "negative";
            }
            else
            {
                result = "zero";
            }
            Console.WriteLine($"The number {number} is {result}.");
        }
    }
}
