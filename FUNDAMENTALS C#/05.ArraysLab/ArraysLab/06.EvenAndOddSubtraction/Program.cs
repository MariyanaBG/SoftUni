using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates the difference between the sum of the even and the sum of the odd numbers in an array.
            //1 2 3 4 5 6 =>  3
            //    Even: 2 + 4 + 6 = 12
            //    Odd: 1 + 3 + 5 = 9
            //    Result: 12 – 9 = 3
            //3 5 7 9     =>  - 24
            //    Even: 0
            //    Odd: 3 + 5 + 7 + 9 = 24
            //    Result: 0 – 24 = -24
            //2 4 6 8 10  =>  30
            //    Even: 2 + 4 + 6 + 8 + 10 = 30
            //    Odd: 0
            //    Result: 30 – 0 = 30

            int[] numbers = Console.ReadLine().Split(' ')
                                              .Select(int.Parse)
                                              .ToArray();
            int evenSum = 0;
            int oddSum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }
            Console.WriteLine(evenSum - oddSum);

        }
    }
}
