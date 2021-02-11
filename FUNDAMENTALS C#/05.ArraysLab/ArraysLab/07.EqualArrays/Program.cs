using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read two arrays and print on the console whether they are identical or not. 
            //Arrays are identical if their elements are equal.
            //If the arrays are identical find the sum of the first one and print on the console following message: 
            //"Arrays are identical. Sum: {sum}", otherwise find the first index where the arrays differ and print 
            //on the console following message: "Arrays are not identical. Found difference at {index} index".
            //    10 20 30
            //    10 20 30    =>  Arrays are identical.Sum: 60
            //    1 2 3 4 5
            //    1 2 4 3 5   =>  Arrays are not identical. Found difference at 2 index 
            //    1
            //    10          =>  Arrays are not identical. Found difference at 0 index

            int[] numbers1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numbers2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool areIdentical = true;

            for (int i = 0; i < numbers1.Length; i++)
            {
                if (numbers1[i] != numbers2[i])
                {
                    areIdentical = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }

            if (areIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {numbers1.Sum()}");
            }
        }
    }
}
