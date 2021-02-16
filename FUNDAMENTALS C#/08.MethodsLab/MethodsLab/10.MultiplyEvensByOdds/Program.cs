using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that multiplies the sum of all even digits of a number by the sum of all odd digits of the same number:
            //    • Create a method called GetMultipleOfEvenAndOdds()
            //    • Create a method GetSumOfEvenDigits()
            //    • Create GetSumOfOddDigits()
            //    • You may need to use Math.Abs() for negative numbers
            //        - 12345 =>  54
            //                        Evens: 2 4
            //                        Odds: 1 3 5
            //                        Even sum: 6
            //                        Odd sum: 9
            //                        6 * 9 = 54

            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            GetMultipleOfEvenAndOdds(number);
        }

        private static void GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            Console.WriteLine(evenSum * oddSum);
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sumOdd = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 == 1)
                {
                    sumOdd += currentDigit;
                }
                number /= 10;
            }
            return sumOdd;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sumEven = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 == 0)
                {
                    sumEven += currentDigit;
                }
                number /= 10;
            }
            return sumEven;
        }
    }
}
