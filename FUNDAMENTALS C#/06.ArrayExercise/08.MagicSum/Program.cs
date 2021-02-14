using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which prints all unique pairs in an array of integers whose sum is equal to a given number.
            //    1 7 6 2 19 23
            //    8
            //                                1 7
            //                                6 2
            //    14 20 60 13 7 19 8
            //    27
            //                                14 13
            //                                20 7
            //                                19 8

            int[] numbers = Console.ReadLine().Split(' ')
                                              .Select(int.Parse)
                                              .ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == number)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                    }
                }
            }


        }
    }
}
