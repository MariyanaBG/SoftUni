using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method for printing triangles as shown below:
            //     3
            //             1
            //             1 2
            //             1 2 3
            //             1 2
            //             1
            //     4
            //             1
            //             1 2
            //             1 2 3
            //             1 2 3 4
            //             1 2 3
            //             1 2
            //             1
            //     Hints 
            //1.After you read the input 
            //2.Start by creating a method for printing a single line from a given start to a given end.
            //  Choose a meaningful name for it, describing its purpose
            //3.Create another method for printing the whole triangle.
            //  Again choose a meaningful name for it, describing its purpose.
            //4.Think how you can use the PrintLine() method to solve the problem
            //5.After you spent some time thinking, you should have come to the conclusion that you will need two loops
            //6.In the first loop you can print the first half of the triangle
            //7.In the second loop you can print the second half of the triangle


            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);

        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintLine(1, i);
            }
            for (int i = number - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
