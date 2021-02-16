using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive a single string. Write a method that prints the middle character.
            //If the length of the string is even there are two middle characters.
            //    aString     =>  r
            //    someText    =>  eT
            //    3245        =>  24

            string text = Console.ReadLine();

            if (text.Length % 2 == 0)
            {
                PrintTwoMiddleCharacters(text);
            }
            else
            {
                PrintOneMiddleCharacter(text);
            }
        }

        private static void PrintOneMiddleCharacter(string text)
        {
            char middleChar = text[text.Length / 2];

            Console.WriteLine($"{middleChar }");
        }

        private static void PrintTwoMiddleCharacters(string text)
        {
            char firstChar = text[text.Length / 2 - 1];
            char secondChar = text[text.Length / 2];

            Console.WriteLine($"{firstChar }{secondChar }");
        }
    }
}
