using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read two integer numbers. Calculate factorial of each number. Divide the first result by the second and print 
            //the division formatted to the second decimal point.
            //    5
            //    2
            //            60.00

            //    6
            //    2
            //            360.00

            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double factorielFirstNumber = Factoriel(firstNumber);
            double factorielSecondNumber = Factoriel(secondNumber);
            PrintDivision(factorielFirstNumber, factorielSecondNumber);
        }

        private static void PrintDivision(double factorielFirstNumber, double factorielSecondNumber)
        {
            double result = factorielFirstNumber / factorielSecondNumber;

            Console.WriteLine($"{result:F2}");
        }

        private static double Factoriel(double number)
        {
            double factoriel = 1;
            if (number > 1)
            {
                for (int i = 2; i <= number; i++)
                {
                    factoriel *= i;
                }
            }
            return factoriel;
        }
    }
}
