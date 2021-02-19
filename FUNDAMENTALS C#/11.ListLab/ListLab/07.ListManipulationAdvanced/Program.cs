using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contains { number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number".
            //PrintEven – print all the even numbers, separated by a space.
            //PrintOdd – print all the odd numbers, separated by a space.
            //GetSum – print the sum of all the numbers.
            //Filter { condition} { number} – print all the numbers that fulfill the given condition.
            //The condition will be either '<', '>', ">=", "<=".
            //After the end command, print the list only if you have made some changes to the original list. 
            //Changes are made only from the commands from the previous task.
            //    2 13 43 876 342 23 543
            //    Contains 100
            //    Contains 543
            //    PrintEven
            //    PrintOdd
            //    GetSum
            //    Filter >= 43
            //    Filter < 100
            //    end
            //                    No such number
            //                    Yes
            //                    2 876 342
            //                    13 43 23 543
            //                    1842
            //                    43 876 342 543
            //                    2 13 43 23

            List<int> numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool isChanged = false;

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
                    case "Add":
                        int number = int.Parse(commandParts[1]);
                        numbersList.Add(number);
                        isChanged = true;
                        break;

                    case "Remove":
                        number = int.Parse(commandParts[1]);
                        numbersList.Remove(number);
                        isChanged = true;
                        break;

                    case "RemoveAt":
                        int index = int.Parse(commandParts[1]);
                        numbersList.RemoveAt(index);
                        isChanged = true;
                        break;

                    case "Insert":
                        number = int.Parse(commandParts[1]);
                        index = int.Parse(commandParts[2]);
                        numbersList.Insert(index, number);
                        isChanged = true;
                        break;

                    case "Contains":
                        //Contains { number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number".
                        number = int.Parse(commandParts[1]);
                        if (numbersList.Contains(number))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        //PrintEven – print all the even numbers, separated by a space.
                        List<int> evenNumbers = new List<int>(numbersList.Count);
                        for (int i = 0; i < numbersList.Count; i++)
                        {
                            if (numbersList[i] % 2 == 0)
                            {
                                evenNumbers.Add(numbersList[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", evenNumbers));
                        break;

                    case "PrintOdd":
                        //PrintOdd – print all the odd numbers, separated by a space.
                        List<int> oddNumbers = new List<int>(numbersList.Count);
                        for (int i = 0; i < numbersList.Count; i++)
                        {
                            if (numbersList[i] % 2 == 1)
                            {
                                oddNumbers.Add(numbersList[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", oddNumbers));
                        break;

                    case "GetSum":
                        //GetSum – print the sum of all the numbers.
                        Console.WriteLine($"{numbersList.Sum()}");
                        break;

                    case "Filter":
                        //Filter { condition} { number} – print all the numbers that fulfill the given condition.
                        //The condition will be either '<', '>', ">=", "<=".
                        string condition = commandParts[1];
                        number = int.Parse(commandParts[2]);
                        List<int> result = new List<int>(numbersList);
                        switch (condition)
                        {
                            case "<":
                                result.RemoveAll(n => n >= number);
                                Console.WriteLine(string.Join(" ", result));
                                break;
                            case ">":
                                result.RemoveAll(n => n <= number);
                                Console.WriteLine(string.Join(" ", result));
                                break;
                            case ">=":
                                result.RemoveAll(n => n < number);
                                Console.WriteLine(string.Join(" ", result));
                                break;
                            case "<=":
                                result.RemoveAll(n => n > number);
                                Console.WriteLine(string.Join(" ", result));
                                break;

                        }

                        break;

                }
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbersList));
            }

        }
    }
}
