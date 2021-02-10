using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main()
        {
            //A number is special when its sum of digits is 5, 7 or 11.
            //Write a program to read an integer n and for all numbers in the range 1…n to print 
            //the number and if it is special or not (True / False).
            //To calculate the sum of digits of given number num, you might repeat the following: 
            //sum the last digit(num % 10) and remove it(sum = sum / 10) until num reaches 0.

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int currentNumber = i;
                bool isSpecial = false;
                while (currentNumber > 0)
                {
                    int currentDigit = currentNumber % 10;
                    sumOfDigits += currentDigit;
                    currentNumber /= 10;
                }
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    isSpecial = true;
                }

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
