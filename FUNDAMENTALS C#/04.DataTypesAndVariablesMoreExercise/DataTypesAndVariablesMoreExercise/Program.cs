using System;

namespace DataTypesAndVariablesMoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive an input until you receive "END".Find what data type is the input. Possible data types are:
            //    • Integer
            //    • Floating point 
            //    • Characters
            //    • Boolean
            //    • Strings
            //Print the result in the following format: "{input} is {data type} type"

            string input = Console.ReadLine();

            string dataType = string.Empty;

            while (input != "END")
            {
                if (Int64.TryParse(input, out _ ))
                {
                    dataType = "integer";
                }
                else if (Double.TryParse(input, out _))
                {
                     dataType = "floating point";
                }
                else if (Char.TryParse(input, out _))
                {
                   dataType = "character";
                }
                else if (Boolean.TryParse(input, out _))
                {
                    dataType = "boolean";
                }
                else
                {
                    dataType = "string";
                }

                Console.WriteLine($"{input} is {dataType} type");

                input = Console.ReadLine();
            }
        }
    }
}
