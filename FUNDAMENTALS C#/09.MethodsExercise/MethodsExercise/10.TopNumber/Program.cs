using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //A top number is an integer that holds the following properties:
            //    • Its sum of digits is divisible by 8, e.g. 8, 16, 88.
            //    • Holds at least one odd digit, e.g. 232, 707, 87578.
            //Write a program to print all master numbers in the range[1…n].
            //    50
            //            17
            //            35

            //    100
            //            17
            //            35
            //            53
            //            71
            //            79
            //            97

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool isSumOfDigitsDivisibleByEight = CheckIfSumOfDigitsDivisibleByEight(i);
                bool hasOneOddDigit = CheckIfHasOddDigit(i);

                if (isSumOfDigitsDivisibleByEight && hasOneOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool CheckIfHasOddDigit(int i)
        {
            bool result = false;
            while (i > 0)
            {
                int currentDigit = i % 10;
                if (currentDigit % 2 == 1)
                {
                    result = true;
                    break;
                }
                i /= 10;
            }
            return result;
        }

        private static bool CheckIfSumOfDigitsDivisibleByEight(int i)
        {
            bool result = false;
            int sum = 0;

            while (i > 0)
            {
                int currentDigit = i % 10;
                sum += currentDigit;
                i /= 10;
            }

            if (sum % 8 == 0)
            {
                result = true;
            }

            return result;
        }
    }
}
