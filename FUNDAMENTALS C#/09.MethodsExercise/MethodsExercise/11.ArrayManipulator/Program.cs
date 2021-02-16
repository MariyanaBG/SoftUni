using System;
using System.Linq;
using System.Text;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line, the initial array is received as a line of integers, separated by a single space
            //• exchange { index} – splits the array after the given index, and exchanges the places of the two resulting sub - arrays.
            //  E.g. [1, 2, 3, 4, 5]->exchange 2->result: [4, 5, 1, 2, 3]
            //  If the index is outside the boundaries of the array, print “Invalid index”
            //• max even/ odd– returns the INDEX of the max even / odd element-> [1, 4, 8, 2, 3]->max odd->print 4
            //• min even/ odd – returns the INDEX of the min even / odd element-> [1, 4, 8, 2, 3]->min even > print 3
            //  ◦ If there are two or more equal min/ max elements, return the index of the rightmost one
            //  ◦ If a min / max even / odd element cannot be found, print “No matches”
            //• first { count} even / odd– returns the first { count} elements-> [1, 8, 2, 3]->first 2 even->print[8, 2]
            //  • last { count} even / odd – returns the last { count} elements-> [1, 8, 2, 3]->last 2 odd->print[1, 3]
            //      ◦ If the count is greater than the array length, print “Invalid count”
            //      ◦ If there are not enough elements to satisfy the count, print as many as you can.If there are zero even / odd elements, print an empty array “[]”
            //  • end – stop taking input and print the final state of the array

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string commandLine = Console.ReadLine();

            string[] commandParts = new string[3];

            while (commandLine != "end")
            {
                commandParts = commandLine.Split();
                string command = commandParts[0];

                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(commandParts[1]);
                        if (index >= numbers.Length || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            int[] exchangedArray = new int[numbers.Length];
                            ExchangeArray(numbers, index).CopyTo(numbers, 0);
                            //string result = String.Join(", ", numbers);
                            //Console.WriteLine($"[{result}]");
                        }
                        break;
                    case "max":
                        string type = commandParts[1];
                        switch (type)
                        {
                            case "even":
                                FindMaxEvenIndex(numbers);
                                break;
                            case "odd":
                                FindMaxOddIndex(numbers);
                                break;
                        }
                        break;
                    case "min":
                        type = commandParts[1];
                        switch (type)
                        {
                            case "even":
                                FindMinEvenIndex(numbers);
                                break;
                            case "odd":
                                FindMinOddIndex(numbers);
                                break;
                        }
                        break;

                    case "first":
                        int count = int.Parse(commandParts[1]);
                        if (count > numbers.Length || count < 0)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            type = commandParts[2];
                            switch (type)
                            {
                                case "even":
                                    FindFirstCountEven(numbers, count);
                                    break;
                                case "odd":
                                    FindFirstCountOdd(numbers, count);
                                    break;
                            }
                        }
                        break;

                    case "last":
                        count = int.Parse(commandParts[1]);
                        if (count > numbers.Length || count < 0)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            type = commandParts[2];
                            switch (type)
                            {
                                case "even":
                                    FindLastCountEven(numbers, count);
                                    break;
                                case "odd":
                                    FindLastCountOdd(numbers, count);
                                    break;
                            }
                        }
                        break;
                }

                commandLine = Console.ReadLine();
            }

            string finalLine = String.Join(", ", numbers);
            Console.WriteLine($"[{finalLine}]");
        }

        private static int[] ExchangeArray(int[] numbers, int index)
        {
            int[] exchangedArray = new int[numbers.Length];

            for (int i = 0, j = index + 1; j < numbers.Length; i++, j++)
            {
                exchangedArray[i] = numbers[j];
            }

            for (int k = exchangedArray.Length - 1 - index, l = 0; k < exchangedArray.Length; k++, l++)
            {
                exchangedArray[k] = numbers[l];
            }

            return exchangedArray;
        }

        private static void FindLastCountOdd(int[] numbers, int count)
        {
            int countPrintedNumbers = 0;
            StringBuilder result = new StringBuilder();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 1)
                {
                    result.Append(numbers[i] + ", ");
                    countPrintedNumbers++;
                    if (countPrintedNumbers == count)
                    {
                        break;
                    }
                }
            }

            if (countPrintedNumbers != 0)
            {
                result.Remove(result.Length - 2, 2);
                
                char[] charArray = result.ToString().ToCharArray();
                Array.Reverse(charArray);
                string reversedString = new string (charArray);
                Console.WriteLine($"[{reversedString}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }

        private static void FindLastCountEven(int[] numbers, int count)
        {
            int countPrintedNumbers = 0;
            StringBuilder result = new StringBuilder();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0)
                {
                    result.Append(numbers[i] + ", ");
                    countPrintedNumbers++;
                    if (countPrintedNumbers == count)
                    {
                        break;
                    }
                }
            }

            if (countPrintedNumbers != 0)
            {
                result.Remove(result.Length - 2, 2);
                char[] charArray = result.ToString().ToCharArray();
                Array.Reverse(charArray);
                string reversedString = new string(charArray);
                Console.WriteLine($"[{reversedString}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }

        private static void FindFirstCountOdd(int[] numbers, int count)
        {
            int countPrintedNumbers = 0;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    result.Append(numbers[i] + ", ");
                    countPrintedNumbers++;
                    if (countPrintedNumbers == count)
                    {
                        break;
                    }
                }
            }

            if (countPrintedNumbers != 0)
            {
                result.Remove(result.Length - 2, 2);
                Console.WriteLine($"[{result}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }

        private static void FindFirstCountEven(int[] numbers, int count)
        {
            int countPrintedNumbers = 0;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result.Append(numbers[i] + ", ");
                    countPrintedNumbers++;
                    if (countPrintedNumbers == count)
                    {
                        break;
                    }
                }
            }

            if (countPrintedNumbers != 0)
            {
                result.Remove(result.Length - 2, 2);
                Console.WriteLine($"[{result}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }

        private static void FindMinOddIndex(int[] numbers)
        {
            bool isFound = false;
            int minOddIndex = 0;
            int minOddNumber = int.MaxValue;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 1 && numbers[i] < minOddNumber)
                {
                    minOddIndex = i;
                    minOddNumber = numbers[i];
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine(minOddIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void FindMinEvenIndex(int[] numbers)
        {
            bool isFound = false;
            int minEvenIndex = 0;
            int minEvenNumber = int.MaxValue;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0 && numbers[i] < minEvenNumber)
                {
                    minEvenIndex = i;
                    minEvenNumber = numbers[i];
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine(minEvenIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void FindMaxOddIndex(int[] numbers)
        {
            bool isFound = false;
            int maxOddIndex = 0;
            int maxOddNumber = int.MinValue;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 1 && numbers[i] > maxOddNumber)
                {
                    maxOddIndex = i;
                    maxOddNumber = numbers[i];
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine(maxOddIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void FindMaxEvenIndex(int[] numbers)
        {
            bool isFound = false;
            int maxEvenIndex = 0;
            int maxEvenNumber = int.MinValue;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0 && numbers[i] > maxEvenNumber)
                {
                    maxEvenIndex = i;
                    maxEvenNumber = numbers[i];
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine(maxEvenIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }


    }
}
