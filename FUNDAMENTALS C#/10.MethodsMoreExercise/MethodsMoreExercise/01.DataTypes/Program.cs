using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that, depending on the first line of the input, reads an int, double or string.
            //    • If the data type is int, multiply the number by 2.
            //    • If the data type is real, multiply the number by 1.5 and format it to the second decimal point.
            //    • If the data type is string, surround the input with "$".
            //Print the result on the console.

            //    int
            //    5
            //            10
            //    real
            //    2
            //            3.00
            //    string
            //    hello
            //            $hello$
            //    Hint
            //    Try to solve the problem using only one method with different overloads.

            string type = Console.ReadLine();
            string data = Console.ReadLine();
            PrintResult(type, data);

        }

        private static void PrintResult(string type, string data)
        {
            string result = string.Empty;
            switch (type)
            {
                case "int":
                    int numberInteger = int.Parse(data);
                    numberInteger *= 2;
                    result = numberInteger.ToString();
                    break;
                case "real":
                    double numberDouble = double.Parse(data);
                    numberDouble *= 1.5;
                    result = $"{numberDouble:F2}";
                    break;
                case "string":
                    result = "$" + data + "$";
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
