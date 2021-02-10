using System;
using System.Numerics;

namespace _03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main()
        {
            //Write program to enter n numbers and calculate and print their exact sum(without rounding).

            int n = int.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine($"{sum}");
        }
    }
}
