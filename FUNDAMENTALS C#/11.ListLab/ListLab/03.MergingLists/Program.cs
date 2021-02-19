using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are going to receive two lists with numbers. Create a result list, which contains the numbers from both of the lists. 
            //The first element should be from the first list, the second from the second list and so on.
            //If the length of the two lists are not equal, just add the remaining elements at the end of the list.
            //3 5 2 43 12 3 54 10 23
            //76 5 34 2 4 12
            //                            3 76 5 5 2 34 43 2 12 4 3 12 54 10 23
            //76 5 34 2 4 12
            //3 5 2 43 12 3 54 10 23
            //                            76 3 5 5 34 2 2 43 4 12 12 3 54 10 23
            //Hint
            //    • Read the two lists
            //    • Create a result list
            //    • Start looping through them until you reach the end of the smallest one
            //    • Finally add the remaining elements(if there are any) to the end of the list

            List<int> numbers1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = new List<int>(numbers1.Count + numbers2.Count);

            int minLenght = Math.Min(numbers1.Count, numbers2.Count);
            int maxLenght = Math.Max(numbers1.Count, numbers2.Count);
            int index = 0;

            for (index = 0; index < minLenght; index++)
            {
                result.Add(numbers1[index]);
                result.Add(numbers2[index]);
            }

            for (int i = index; i < maxLenght; i++)
            {
                if (numbers1.Count > minLenght)
                {
                    result.Add(numbers1[i]);
                }
                else
                {
                    result.Add(numbers2[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
