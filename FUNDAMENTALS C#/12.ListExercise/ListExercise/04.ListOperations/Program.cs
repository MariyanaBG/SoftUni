using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given a list of integer numbers on the first line of input.
            //You will be receiving operations you have to apply on the list until you receive the "End" command.
            //The possible commands are:
            //    • Add { number} – add number at the end.
            //    • Insert { number} { index} – insert number at given index.
            //    • Remove { index} – remove at index.
            //    • Shift left { count} – first number becomes last ‘count’ times.
            //    • Shift right { count} – last number becomes first ‘count’ times.
            //Note: there is a possibility that the given index is outside of the bounds of the array.In that case print "Invalid index"
            //        1 23 29 18 43 21 20
            //        Add 5
            //        Remove 5
            //        Shift left 3
            //        Shift left 1
            //        End
            //                                43 20 5 1 23 29 18
            //        5 12 42 95 32 1
            //        Insert 3 0
            //        Remove 10
            //        Insert 8 6
            //        Shift right 1
            //        Shift left 2
            //        End
            //                                Invalid index
            //                                5 12 42 95 32 8 1 3

            List<int> numberList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandParts = command.Split(' ');

                switch (commandParts[0])
                {
                    //    • Add { number} – add number at the end.
                    case "Add":
                        int number = int.Parse(commandParts[1]);
                        numberList.Add(number);
                        break;

                    //    • Insert { number} { index} – insert number at given index.
                    case "Insert":
                        number = int.Parse(commandParts[1]);
                        int index = int.Parse(commandParts[2]);
                        if (index < 0 || index >= numberList.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numberList.Insert(index, number);
                        }
                        break;

                    //    • Remove { index} – remove at index.
                    case "Remove":
                        index = int.Parse(commandParts[1]);
                        if (index < 0 || index >= numberList.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numberList.RemoveAt(index);
                        }
                        break;

                    case "Shift":
                        int count = int.Parse(commandParts[2]);

                        switch (commandParts[1])
                        {
                            //    • Shift left { count} – first number becomes last ‘count’ times.
                            case "left":

                                for (int i = 0; i < count; i++)
                                {
                                    numberList.Add(numberList[0]);
                                    numberList.RemoveAt(0);
                                }

                                break;

                            //    • Shift right { count} – last number becomes first ‘count’ times.
                            case "right":

                                for (int i = 0; i < count; i++)
                                {
                                    numberList.Insert(0, numberList[numberList.Count - 1]);
                                    numberList.RemoveAt(numberList.Count - 1);
                                }

                                break;
                        }

                        break;
                }



                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numberList));
        }
    }
}
