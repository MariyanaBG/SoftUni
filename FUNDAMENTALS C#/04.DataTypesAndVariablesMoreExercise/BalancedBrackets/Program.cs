using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive n lines.On those lines, you will receive one of the following:
            //    • Opening bracket – “(“,
            //    • Closing bracket – “)” or
            //    • Random string
            //Your task is to find out if the brackets are balanced.
            //That means after every closing bracket should follow an opening one.
            //Nested parentheses are not valid, and if two consecutive opening brackets exist,
            //the expression should be marked as unbalanced.
            //Input
            //    • On the first line, you will receive n – the number of lines, which will follow
            //    • On the next n lines, you will receive “(”, “)” or another string
            //Output
            //You have to print “BALANCED”, if the parentheses are balanced and “UNBALANCED” otherwise.
            //Constraints
            //    • n will be in the interval[1…20]
            //    • The length of the stings will be between[1…100] characters

            int lines = int.Parse(Console.ReadLine());
            int countOpeningBracets = 0;
            int countClosingBracets = 0;

            bool lastIsOpening = false;
            bool lastIsClosing = false;
            bool isNested = false;


            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    if (lastIsOpening)
                    {
                        isNested = true;
                        countOpeningBracets++;
                        lastIsOpening = true;
                        lastIsClosing = false;
                    }
                    else
                    {
                        countOpeningBracets++;
                        lastIsOpening = true;
                        lastIsClosing = false;
                    }
                }
                else if (input == ")")
                {
                    if (lastIsClosing)
                    {
                        isNested = true;
                        countClosingBracets++;
                        lastIsOpening = false;
                        lastIsClosing = true;
                    }
                    else
                    {
                        countClosingBracets++;
                        lastIsOpening = false;
                        lastIsClosing = true;
                    }
                }
            }
            if (countOpeningBracets == countClosingBracets && isNested == false)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
