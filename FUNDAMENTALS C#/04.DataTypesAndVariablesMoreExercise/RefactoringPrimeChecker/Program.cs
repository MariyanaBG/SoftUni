using System;

namespace RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a program that checks if numbers in a given range[2...N] are prime. 
            //For each number is printed "{number} -> {true or false}".
            //The code however, is not very well written.Your job is to modify it in a way that is easy to read and understand.

            int lastNumber = int.Parse(Console.ReadLine());
            bool isPrime = true;

            for (int number = 2; number <= lastNumber; number++)
            {
                if (number == 2)
                {
                    isPrime = true;
                }
                else if (number % 2 == 0)
                {
                    isPrime = false;
                }
                else
                {
                    for (int divisor = 3; divisor <= number; divisor += 2)
                    {
                        if (number != divisor && number % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        else
                        {
                            isPrime = true;

                        }
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine($"{number} -> true");
                }
                else
                {
                    Console.WriteLine($"{number} -> false");
                }

            }
        }
    }
}
