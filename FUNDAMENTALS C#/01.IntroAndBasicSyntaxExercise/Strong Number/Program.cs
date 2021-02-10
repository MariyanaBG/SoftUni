using System;

namespace Strong_Number
{
    class Program
    {
        static void Main()
        {
            //Write a program to check if a given number is a strong number or not.
            //A number is strong if the sum of the Factorial of each digit is equal to the number. 
            //For example 145 is a strong number, because 1! + 4! + 5! = 145.
            //Print "yes" if the number is strong and “no” if the number is not strong.

            int number = int.Parse(Console.ReadLine());

            int currentNumber = number;
            int sum = 0;
            while (currentNumber > 0)
            {
                int currentDigit = currentNumber % 10;
                int factoriel = 1;
                for (int i = 1; i <= currentDigit; i++)
                {
                    factoriel *= i;
                }
                sum += factoriel;
                currentNumber /= 10;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
