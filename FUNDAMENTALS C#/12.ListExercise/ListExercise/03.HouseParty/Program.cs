using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that keeps track of guests, that are going to a house party. On the first line of input, 
            //you are going to receive the number of commands you are going to receive. On the next lines you are going
            //to receive one of the following messages:
            //    • "{name} is going!"
            //    • "{name} is not going!"
            //If you receive the first message, you have to add the person if he / she is not in the list and if he / she
            //is in the list print on the console: "{name} is already in the list!".If you receive the second message, 
            //you have to remove the person if he / she is in the list and if not print: "{name} is not in the list!".
            //At the end print all the guests.
            //4
            //Allie is going!
            //George is going!
            //John is not going!
            //George is not going!
            //                        John is not in the list!
            //                        Allie
            //5
            //Tom is going!
            //Annie is going!
            //Tom is going!
            //Garry is going!
            //Jerry is going!
            //                        Tom is already in the list!
            //                        Tom
            //                        Annie
            //                        Garry
            //                        Jerry

            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>(numberOfCommands);

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[2] == "not")
                {
                    if (guests.Contains(command[0]))
                    {
                        guests.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {

                        guests.Add(command[0]);
                    }
                }
            }

            foreach (string name in guests)
            {
                Console.WriteLine(name);
            }

        }
    }
}
