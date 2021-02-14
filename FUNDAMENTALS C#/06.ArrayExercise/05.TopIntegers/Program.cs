using System;
using System.Linq;
using System.Numerics;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to find all the top integers in an array. 
            //A top integer is an integer which is bigger than all the elements to its right. 
            //    1 4 3 2
            //                            4 3 2
            //    14 24 3 19 15 17
            //                            24 19 17
            //    27 19 42 2 13 45 48
            //                            48

            BigInteger [] numbers = Console.ReadLine().Split(' ')
                                              .Select(BigInteger.Parse)
                                              .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTopInteger = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
