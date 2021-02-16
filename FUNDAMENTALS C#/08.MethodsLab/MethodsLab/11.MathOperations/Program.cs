using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that receives two number and an operator, calculates the result and returns it. 
            //You will be given three lines of input. The first will be the first number, the second one will be the operator 
            //and the last one will be the second number.The possible operators are: / *+-
            //Print the result rounded up to the second decimal point.
            //        5
            //        *
            //        5
            //            25
            //        4
            //        +
            //        8
            //            12

            int firstNumber = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            double result = Calculate(firstNumber, @operator, secondNumber);
            Console.WriteLine(result);

        }

        private static double Calculate(int firstNumber, string @operator, int secondNumber)
        {
            double result = 0.0;

            switch (@operator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = (double)firstNumber / secondNumber;
                    break;
            }

            return result;
        }
    }
}
