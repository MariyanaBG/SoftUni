using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read an array from the console and sum only the even numbers.
            //    1 2 3 4 5 6 => 12
            //    3 5 7 9     => 0
            //    2 4 6 8 10  => 30

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
