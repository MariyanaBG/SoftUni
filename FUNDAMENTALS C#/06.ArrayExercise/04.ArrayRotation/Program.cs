using System;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that receives an array and number of rotations you have to perform
            //(first element goes at the end) Print the resulting array.
            //    51 47 32 61 21
            //    2
            //                    32 61 21 51 47
            //    32 21 61 1
            //    4
            //                    32 21 61 1
            //    2 4 15 31
            //    5
            //                    4 15 31 2

            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());

            string[] result = new string[input.Length];
            string lastNumber = "";
            for (int i = 0; i < n; i++)
            {
                lastNumber = input[0];
                for (int j = 0; j < input.Length - 1; j++)
                {
                    result[j] = input[j + 1];
                }
                result[result.Length - 1] = lastNumber;
                for (int k = 0; k < input.Length; k++)
                {
                    input[k] = result[k];
                }
            }
            Console.WriteLine(String.Join(' ', input));
        }
    }
}
