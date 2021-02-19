using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a list of integers.Then until you receive "end", you will receive different commands:
            //    Add { number}: add a number to the end of the list.
            //    Remove { number}: remove a number from the list.
            //    RemoveAt { index}: remove a number at a given index.
            //    Insert { number} { index}: insert a number at a given index.
            //When you receive the "end" command, print the final state of the list(separated by spaces).
            //    4 19 2 53 6 43
            //    Add 3
            //    Remove 2
            //    RemoveAt 1
            //    Insert 8 3
            //    end
            //                    4 53 6 8 43 3

            List<int> numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] commandParts = command.Split(' ');

                switch (commandParts[0])
                {
                    //    Insert { number} { index}: insert a number at a given index.
                    case "Add":
                        int number = int.Parse(commandParts[1]);
                        numbersList.Add(number);
                        break;
                    case "Remove":
                        number = int.Parse(commandParts[1]);
                        numbersList.Remove(number);
                        break;
                    case "RemoveAt":
                        int index = int.Parse(commandParts[1]);
                        numbersList.RemoveAt(index);
                        break;
                    case "Insert":
                        number = int.Parse(commandParts[1]);
                        index = int.Parse(commandParts[2]);
                        numbersList.Insert(index, number);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
