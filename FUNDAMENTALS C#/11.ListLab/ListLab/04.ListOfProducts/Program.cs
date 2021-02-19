using System;
using System.Collections.Generic;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read a number n and n lines of products.Print a numbered list of all the products ordered by name.
            //    4
            //    Potatoes
            //    Tomatoes
            //    Onions
            //    Apples
            //                1.Apples
            //                2.Onions
            //                3.Potatoes
            //                4.Tomatoes

            int n = int.Parse(Console.ReadLine());
            List<string> listOfProducts = new List<string>(n);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                listOfProducts.Add(input);
            }

            listOfProducts.Sort();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.{listOfProducts[i]}");
            }


        }
    }
}
