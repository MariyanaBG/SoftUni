using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method that calculates and returns the value of a number raised to a given power:
            //    2
            //    8
            //        256
            //    3
            //    4
            //        81
            //Hints
            //    1.As usual, read the input
            //    2.Create a method which will have two parameters - the number and the power, and will return a result of type double
            //    3.Print the result

            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

        private static double RaiseToPower(double number, int power)
        {
            double result = Math.Pow(number, (double)power);
            return result;
        }
    }
}
