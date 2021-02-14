using System;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which prints common elements in two arrays. 
            //You have to compare the elements of the second array to the elements of the first.
            //    Hey hello 2 4
            //    10 hey 4 hello
            //                    4 hello
            //    S of t un i
            //    of i 10 un
            //                    of i un
            //    i love to code
            //    code i love to
            //                    code i love to

            string[] array1 = Console.ReadLine().Split(' ');
            string[] array2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array2[i] == array1[j])
                    {
                        Console.Write(array2[i] + " ");
                        break;
                    }

                }
            }
            Console.WriteLine();

        }
    }
}
