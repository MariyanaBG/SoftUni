using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Write a program that determines if there exists an element in the array such that 
            //    the sum of the elements on its left is equal to the sum of the elements on its right
            //    (there will never be more than 1 element like that). 
            //    If there are no elements to the left / right, their sum is considered to be 0.
            //    Print the index that satisfies the required condition or "no" if there is no such index.
            //    1 2 3 3 =>  2       At a[2] -> left sum = 3, right sum = 3
            //    1 2     =>  no
            //    1       =>  0
            //    1 2 3   =>  no
            //    10 5 5 99 3 4 2 5 1 1 4 =>  3

            int[] numbers = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    leftSum = 0;
                    rightSum = numbers.Sum() - numbers[0];
                }
                else
                {
                    leftSum += numbers[i - 1];
                    rightSum -= numbers[i];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            if (leftSum != rightSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
