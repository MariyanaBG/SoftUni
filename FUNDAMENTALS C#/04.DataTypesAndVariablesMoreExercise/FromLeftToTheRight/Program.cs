using System;
using System.Numerics;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive number which represent how many lines we will get as an input.
            //On the next N lines, you will receive a string with 2 numbers separated by single space.
            //You need to compare them.If the left number is greater than the right number, 
            //you need to print the sum of all digits in the left number, otherwise print the sum of all digits in the right number.

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int indexOfSpace = input.IndexOf(' ');

                BigInteger leftNumber = BigInteger.Parse(input.Substring(0, indexOfSpace));
                BigInteger rightNumber = BigInteger.Parse(input.Substring(indexOfSpace + 1, input.Length - indexOfSpace - 1));

                int sum = 0;
                int currentDigit = 0;
                

                if (leftNumber > rightNumber)
                {
                    while (leftNumber != 0)
                    {
                        currentDigit = (int) BigInteger.Remainder( leftNumber , 10);
                        sum += currentDigit;
                        leftNumber /= 10;
                    }
                }
                else
                {
                    while (rightNumber != 0)
                    {
                        currentDigit = (int)BigInteger.Remainder(rightNumber, 10);
                        sum += currentDigit;
                        rightNumber /= 10;
                    }
                }

                Console.WriteLine(Math.Abs(sum));

            }
        }
    }
}
