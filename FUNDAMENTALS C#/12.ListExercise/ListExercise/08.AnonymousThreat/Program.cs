using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Anonymous have created a cyber hypervirus, which steals data from the CIA. You, as the lead security developer in CIA, 
            //have been tasked to analyze the software of the virus and observe its actions on the data.The virus is known for his 
            //innovative and unbeleivably clever technique of merging and dividing data into partitions.
            //You will receive a single input line, containing strings, separated by spaces.The strings may contain any ASCII character 
            //except whitespace.Then you will begin receiving commands in one of the following formats:
            //    • merge { startIndex} { endIndex}
            //    • divide { index} { partitions}
            //Every time you receive the merge command, you must merge all elements from the startIndex, till the endIndex. 
            //In other words, you should concatenate them. 
            //    Example: { abc, def, ghi} -> merge 0 1-> { abcdef, ghi}
            //If any of the given indexes is out of the array, you must take only the range that is inside the array and merge it.
            //Every time you receive the divide command, you must divide the element at the given index, into several small substrings 
            //with equal length.The count of the substrings should be equal to the given partitions. 
            //    Example: { abcdef, ghi, jkl} -> divide 0 3-> { ab, cd, ef, ghi, jkl}
            //If the string cannot be exactly divided into the given partitions, make all partitions except the last with equal lengths, 
            //and make the last one – the longest. 
            //    Example: { abcd, efgh, ijkl} -> divide 0 3-> { a, b, cd, efgh, ijkl}
            //The input ends when you receive the command “3:1”. At that point you must print the resulting elements, joined by a space.

            List<string> input = Console.ReadLine().Split(' ').ToList();
            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] commandParts = command.Split(' ');

                switch (commandParts[0])
                {
                    case "merge":
                        int startIndex = int.Parse(commandParts[1]);
                        if (startIndex < 0 || startIndex >= input.Count)
                        {
                            startIndex = 0;
                        }
                        int endIndex = int.Parse(commandParts[2]);
                        if (endIndex >= input.Count || endIndex < 0)
                        {
                            endIndex = input.Count - 1;
                        }
                        StringBuilder concatenetedString = new StringBuilder();

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concatenetedString.Append(input[i]);
                        }

                        for (int i = 0; i <= endIndex - startIndex; i++)
                        {
                            input.RemoveAt(startIndex);
                        }

                        input.Insert(startIndex, concatenetedString.ToString());
                        break;

                    case "divide":
                        int index = int.Parse(commandParts[1]);
                        int partitions = int.Parse(commandParts[2]);
                        string textToDivide = input[index];
                        int partitionLenght = textToDivide.Length / partitions;



                        for (int i = 1; i <= partitions - 1; i++)
                        {
                            input.Insert(index + i, textToDivide.Substring(0, partitionLenght));
                            textToDivide = textToDivide.Remove(0, partitionLenght);
                        }

                        input.Insert(index + partitions, textToDivide);
                        input.RemoveAt(index);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
