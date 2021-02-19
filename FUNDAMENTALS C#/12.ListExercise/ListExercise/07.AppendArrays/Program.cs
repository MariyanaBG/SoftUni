using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to append several arrays of numbers.
            //    • Arrays are separated by '|'.
            //    • Values are separated by spaces(' ', one or several).
            //    • Order the arrays from the last to the first, and their values from left to right.
            //        1 2 3 | 4 5 6 | 7  8
            //                                        7 8 4 5 6 1 2 3
            //        7 | 4  5 | 1 0 | 2 5 | 3
            //                                        3 2 5 1 0 4 5 7
            //        1 | 4 5 6 7 | 8 9
            //                                        8 9 4 5 6 7 1

            string[] arrays = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<int> orderderArray = new List<int>(arrays.Length);

            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                int[] numbers = arrays[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < numbers.Length; j++)
                {
                    orderderArray.Add(numbers[j]);
                }
            }

            Console.WriteLine(string.Join(" ", orderderArray));
        }
    }
}
