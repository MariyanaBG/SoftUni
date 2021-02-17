using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that sums all of the numbers in a list in the following order:
            //first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.
            //    1 2 3 4 5
            //                6 6 3
            //    1 2 3 4
            //                5 5

            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            int count = numbers.Count;

            for (int i = 0; i < count / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
