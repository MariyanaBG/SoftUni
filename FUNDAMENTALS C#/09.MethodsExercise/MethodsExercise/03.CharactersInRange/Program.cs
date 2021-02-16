using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that receives two characters and prints on a single line all the characters in between them according to ASCII.
            //    a
            //    d
            //        b c
            //    #
            //    :
            //        $ % &' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9
            //    C
            //    #
            //        $ % &' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9 : ; < = > ? @ A B

            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintCharactersBetween(firstChar, secondChar);

        }

        private static void PrintCharactersBetween(char firstChar, char secondChar)
        {
            if (firstChar < secondChar)
            {
                for (int i = firstChar + 1; i < (int)secondChar; i++)
                {
                    Console.Write($"{(char)i} ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = secondChar + 1; i < (int)firstChar; i++)
                {
                    Console.Write($"{(char)i} ");
                }
                Console.WriteLine();
            }

        }
    }
}
