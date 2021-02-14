using System;

namespace _03.RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            if (number == 1 || number == 2)
            {
                result = 1;
            }
            else
            {
                int firstNumber = 1;
                int secondNumber = 1;
                for (int i = 3; i <= number; i++)
                {
                    result = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = result;

                }
            }
            Console.WriteLine(result);
        }
    }
}
