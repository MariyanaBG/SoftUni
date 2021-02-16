using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive 3 integers.Write a method Sum to get the sum of the first two integers and Subtract method 
            //that subtracts the third integer from the result from the Sum method.
            //    23
            //    6
            //    10
            //            19
            //    1
            //    17
            //    30
            //            - 12
            //    42
            //    58
            //    100
            //            0

            int firstNumber = int.Parse(Console.ReadLine());
            int secondtNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = Sum(firstNumber, secondtNumber);
            int result = Subtract(sum, thirdNumber);
            Console.WriteLine(result);

        }

        private static int Subtract(int sum, int thirdNumber)
        {
            int result = sum - thirdNumber;
            return result;
        }

        private static int Sum(int firstNumber, int secondtNumber)
        {
            int result = firstNumber + secondtNumber;
            return result;
        }
    }
}
