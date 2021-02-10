using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given a single integer.Your task is to find the sum of its digits.

            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (number > 0)
            {
                int currentDigit = number % 10;
                sum += currentDigit;
                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
