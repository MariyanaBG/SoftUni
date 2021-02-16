using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method GetMax() that returns the greater of two values(the values can be of type int, char or string)
            //    int
            //    2
            //    16
            //            16
            //    char
            //    a
            //    z
            //            z
            //    string
            //    aaa
            //    bbb
            //            bbb

            string type = Console.ReadLine().ToLower();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int firstNumber = int.Parse(firstValue);
                    int secondNumber = int.Parse(secondValue);
                    GetMax(firstNumber, secondNumber);
                    break;
                case "char":
                    char firstChar = char.Parse(firstValue);
                    char secondChar = char.Parse(secondValue);
                    GetMax(firstChar, secondChar);
                    break;
                case "string":
                    GetMax(firstValue, secondValue);
                    break;
            }


        }

        private static void GetMax(string firstValue, string secondValue)
        {
            string result = string.Empty;
            if (firstValue.CompareTo(secondValue) == 1)
            {
                result = firstValue;
            }
            else
            {
                result = secondValue;
            }
            Console.WriteLine(result);
        }

        private static void GetMax(int firstNumber, int secondNumber)
        {
            int result = (firstNumber > secondNumber ? firstNumber : secondNumber);
            Console.WriteLine(result);
        }

        private static void GetMax(char firstChar, char secondChar)
        {
            char result = '\0';
            if (firstChar > secondChar)
            {
                result = firstChar;
            }
            else
            {
                result = secondChar;
            }
            Console.WriteLine(result);
        }
    }
}
