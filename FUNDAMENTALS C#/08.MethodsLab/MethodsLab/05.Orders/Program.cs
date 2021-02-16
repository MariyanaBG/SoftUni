using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that calculates the total price of an order and prints it on the console.
            //The method should receive one of the following products: coffee, coke, water, snacks; 
            //and a quantity of the product. The prices for a single piece of each product are: 
            //    • coffee – 1.50
            //    • water – 1.00
            //    • coke – 1.40
            //    • snacks – 2.00
            //Print the result formatted to the second decimal place
            //    water
            //    5
            //                5.00
            //    coffee
            //    2
            //                3.00
            //    Hints
            //       1.Read the first two lines
            //       2.Create a method the pass the two variables in
            //       3.Print the result in the method

            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PrintOrderTotalPrice(product, quantity);
        }

        private static void PrintOrderTotalPrice(string product, int quantity)
        {
            double totalPrice = 0.0;
            switch (product)
            {
                case "coffee":
                    totalPrice = quantity * 1.50;
                    break;
                case "coke":
                    totalPrice = quantity * 1.40;
                    break;
                case "water":
                    totalPrice = quantity * 1.00;
                    break;
                case "snacks":
                    totalPrice = quantity * 2.00;
                    break;
            }
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
