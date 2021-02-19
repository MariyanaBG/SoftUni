using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. 
            //In case there are no elements left in the list, print "empty".
            //    10 -5 7 9 -33 50
            //                            50 9 7 10
            //    7 -2 -10 1
            //                            1 7
            //    -1 -2 -3
            //                            empty

            List<int> positiveNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            positiveNumbers.RemoveAll(n => n < 0);

            positiveNumbers.Reverse();

            if (positiveNumbers.Count != 0)
            {
                Console.WriteLine(string.Join(" ", positiveNumbers));
            }
            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}
