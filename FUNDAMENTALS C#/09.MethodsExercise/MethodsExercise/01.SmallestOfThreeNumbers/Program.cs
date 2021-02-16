using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method to print the smallest of three integer numbers.Use appropriate name for the method.

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            PrintTheSmalest(a, b, c);

        }

        private static void PrintTheSmalest(int a, int b, int c)
        {
            int result = GetSmaller(GetSmaller(a, b), c);
            Console.WriteLine(result);
        }

        private static int GetSmaller(int a, int b)
        {
            int result = (a < b ? a : b);
            return result;
        }
    }
}
