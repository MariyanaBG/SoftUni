using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which reads a list of integers from the console and receives commands, which manipulate the list.
            //Your program may receive the following commands:
            //    • Delete { element} – delete all elements in the array, which are equal to the given element.
            //    • Insert { element} { position} – insert an element and the given position.
            //You should stop the program when you receive the command "end".
            //Print the numbers in the array separated by a single whitespace.
            //    1 2 3 4 5 5 5 6
            //    Delete 5
            //    Insert 10 1
            //    Delete 5
            //    end
            //                                        1 10 2 3 4 6
            //    20 12 4 319 21 31234 2 41 23 4
            //    Insert 50 2
            //    Insert 50 5
            //    Delete 4
            //    end
            //                                        20 12 50 319 50 21 31234 2 41 23

            List<int> numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandParts = command.Split(' ');

                switch (commandParts[0])
                {
                    case "Delete":
                        int element = int.Parse(commandParts[1]);
                        numbersList.RemoveAll(n => n == element);
                        break;
                    case "Insert":
                        element = int.Parse(commandParts[1]);
                        int position = int.Parse(commandParts[2]);
                        numbersList.Insert(position, element);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
