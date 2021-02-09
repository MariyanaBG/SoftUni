using System;

namespace Divison
{
    class Program
    {
        static void Main()
        {
            //You will be given an integer and you have to print on the console whether that number is divisible by 
            //    the following numbers: 2, 3, 6, 7, 10.You should always take the bigger division. If the number is 
            //    divisible by both 2 and 3 it is also divisible by 6 and you should print only the division by 6.
            //    If a number is divisible by 2 it is sometimes also divisible by 10 and you should print the division 
            //    by 10.If the number is not divisible by any of the given numbers print “Not divisible”. 
            //    Otherwise print “The number is divisible by { number}”.

            int number = int.Parse(Console.ReadLine());
            int divisibleNumber = 0;

            if (number % 10 == 0)
            {
                divisibleNumber = 10;
            }
            else if (number % 7 == 0)
            {
                divisibleNumber = 7;
            }
            else if (number % 6 == 0)
            {
                divisibleNumber = 6;
            }
            else if (number % 3 == 0)
            {
                divisibleNumber = 3;
            }
            else if (number % 2 == 0)
            {
                divisibleNumber = 2;
            }

            if (divisibleNumber != 0)
            {
                Console.WriteLine($"The number is divisible by {divisibleNumber}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
