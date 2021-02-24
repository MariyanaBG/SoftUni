using System;
using System.Numerics;

namespace _02.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive N – a number in the range[0 – 1000]. Calculate the Factorial of N and print the result.

            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
