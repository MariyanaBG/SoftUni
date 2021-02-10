using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main()
        {
            //You are given a working code that is a solution to Problem 5.
            //Special Numbers. However, the variables are improperly named, 
            //declared before they are needed and some of them are used for multiple things. 
            //Without using your previous solution, modify the code so that it is easy to read and understand.

            //• Reduce the span of the variables by declaring them in the moment they receive a value, not before
            //• Rename your variables to represent their real purpose(example: "toe" should become isSpecialNum, etc.)
            //• Search for variables that have multiple purpose.If you find any, introduce a new variable

            int n = int.Parse(Console.ReadLine());
            for (int number = 1; number <= n; number++)
            {
                int sum = 0;
                int currentNumber = number;
                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;
                }
                bool isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", number, isSpecialNum);
                // number = currentNumber;
            }
        }
    }
}
