using System;

namespace _02.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read n numbers and print them in reverse order. 

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }
            Array.Reverse(numbers);

            string result = String.Join(" ", numbers);
            Console.WriteLine(result);
        }
    }
}
