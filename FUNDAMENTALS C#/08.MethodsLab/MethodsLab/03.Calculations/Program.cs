using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that receives a string on the first line(add, multiply, subtract, divide) 
            //and on the next two lines receives two numbers.Create four methods(for each calculation) 
            //and invoke the right one depending on the command.The method should also print the result(needs to be void)
            //    subtract
            //    5
            //    4
            //                1
            //    divide
            //    8
            //    4
            //                2

            string calculationType = Console.ReadLine().ToLower();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (calculationType)
            {
                case "add":
                    Add(firstNumber, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, secondNumber);
                    break;
                case "subtract":
                    Subtract(firstNumber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber, secondNumber);
                    break;
            }


        }

        private static void Divide(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber / secondNumber);
        }

        private static void Subtract(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }

        private static void Multiply(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }

        private static void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }
    }
}
