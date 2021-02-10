using System;

namespace Print_and_Sum
{
    class Program
    {
        static void Main()
        {
            //Write a program to display numbers from given start to given end and their sum.
            //    All the numbers will be integers. On the first line you will receive the start, on the second the end.

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();

            Console.WriteLine($"Sum: {sum}");

        }
    }
}
