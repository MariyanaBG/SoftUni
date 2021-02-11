using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read an array of real numbers(space separated), round them in "away from 0" style and print the output as in the examples:
            //    0.9 1.5 2.4 2.5 3.14
            //                0.9 => 1
            //                1.5 => 2
            //                2.4 => 2
            //                2.5 => 3
            //                3.14 => 3
            //    - 5.01 - 1.599 - 2.5 - 1.50 0
            //                - 5.01 => -5
            //                - 1.599 => -2
            //                - 2.5 => -3
            //                - 1.50 => -2
            //                0 => 0

            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{Convert.ToDecimal(numbers[i])} => {Math.Round(Convert.ToDecimal(numbers[i]), MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
