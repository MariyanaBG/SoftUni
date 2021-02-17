using System;
using System.Text;

namespace _04.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the "Tribonacci" sequence, every number is formed by the sum of the previous 3.
            //You are given a number num. Write a program that prints num numbers from the Tribonacci sequence, 
            //each on a new line, starting from 1.The input comes as a parameter named num.The value num will always be positive integer.
            //    4
            //            1 1 2 4
            //    8
            //            1 1 2 4 7 13 24 44

            int num = int.Parse(Console.ReadLine());
            PrintTribonacciSequence(num);
        }

        private static void PrintTribonacciSequence(int num)
        {
            if (num == 1)
            {
                Console.WriteLine("1");
            }
            else if (num == 2)
            {
                Console.WriteLine("1 1");
            }
            else if (num == 3)
            {
                Console.WriteLine("1 1 2");
            }
            else
            {
                int first = 1;
                int second = 1;
                int third = 2;

                StringBuilder result = new StringBuilder();
                result.Append("1 1 2 ");

                for (int i = 4; i <= num; i++)
                {
                    int sum = first + second + third;
                    result.Append(sum + " ");
                    first = second;
                    second = third;
                    third = sum;
                }

                Console.WriteLine(result);
            }
        }
    }
}
