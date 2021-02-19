using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive a list of wagons(integers) on the first line. Every integer represents the number of passengers 
            //that are currently in each of the wagons. On the next line, you will get the max capacity of each wagon(a single integer). 
            //Until you receive "end" you will be given two types of input:
            //    • Add { passengers} – add a wagon to the end with the given number of passengers.
            //    • { passengers}-find an existing wagon to fit every passenger, starting from the first wagon.
            //At the end print the final state of the train(each of the wagons, separated by a space).
            //    32 54 21 12 4 0 23
            //    75
            //    Add 10
            //    Add 0
            //    30
            //    10
            //    75
            //    end
            //                            72 54 21 12 4 75 23 10 0
            //    0 0 0 10 2 4
            //    10
            //    Add 10
            //    10
            //    10
            //    10
            //    8
            //    6
            //    end
            //                            10 10 10 10 10 10 10

            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] commandParts = input.Split(' ');

                if (commandParts[0] == "Add")
                {
                    int number = int.Parse(commandParts[1]);
                    wagons.Add(number);
                }
                else
                {
                    int number = int.Parse(commandParts[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + number <= capacity)
                        {
                            wagons[i] += number;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
