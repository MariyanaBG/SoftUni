using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read an array of integers and condense them by summing adjacent couples of elements 
            //until a single integer is obtained.For example, if we have 3 elements { 2, 10, 3}, we sum the first two 
            //and the second two elements and obtain { 2 + 10, 10 + 3} = { 12, 13}, then we sum again all adjacent elements
            //and obtain { 12 + 13} = { 25}.
            //    2 10 3      =>  25
            //                    2 10 3  2 + 10  10 + 3  12 13  12 + 13  25
            //    5 0 4 1 2   =>  35
            //                    5 0 4 1 2  5 + 0  0 + 4  4 + 1  1 + 2  5 4 5 3  5 + 4  4 + 5  5 + 3  9 9 8  9 + 9  9 + 8  18 17  18 + 17  35
            //    1           =>  1
            //                    1 is already condensed to number

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condensed = new int[numbers.Length - 1];

            int lenght = numbers.Length;
                while (lenght != 1)
                {
                    for (int i = 0; i < lenght - 1; i++)
                    {
                        condensed[i] = (numbers[i] + numbers[i + 1]);
                    }
                    for (int j = 0; j < condensed.Length; j++)
                    {
                        numbers[j] = condensed[j];
                        condensed[j] = 0;
                    }
                    //numbers[condensed.Length] = 0;
                    lenght--;
                }
                Console.WriteLine(numbers[0]);
        }
    }
}
