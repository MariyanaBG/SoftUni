using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main()
        {
            //You task is to calculate the total price of a purchase from a vending machine.
            //Until you receive “Start” you will be given different coins that are being inserted in the machine. 
            //You have to sum them in order to have the total money inserted.There is a problem though.
            //Your vending machine only works with 0.1, 0.2, 0.5, 1, and 2 coins.
            //If someone tries to insert some other coins you have to display “Cannot accept { money}” 
            //and not add it to the total money. On the next few lines until you receive “End” you will be given products to purchase.
            //Your machine has however only “Nuts”, “Water”, “Crisps”, “Soda”, “Coke”. 
            //The prices are: 2.0, 0.7, 1.5, 0.8, 1.0 respectively.
            //If the person tries to purchase a not existing product print “Invalid product”. 
            //Be careful that the person may try to purchase a product they don’t have the money for. 
            //In that case print “Sorry, not enough money”. If the person purchases a product successfully print “Purchased { product name}”.
            //After the “End” command print the money that are left formatted to the second decimal point 
            //in the format “Change: { money left}”.

            string input = Console.ReadLine();
            double totalMoney = 0.0;
            while (input != "Start")
            {
                double coin = double.Parse(input);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    totalMoney += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                    input = Console.ReadLine();
                    continue;
                }
                input = Console.ReadLine();
            }

            string product = Console.ReadLine().ToLower();
            while (product != "end")
            {
                double productPrice = 0.0;
                if (product == "nuts")
                {
                    productPrice = 2.0;
                }
                else if (product == "water")
                {
                    productPrice = 0.7;
                }
                else if (product == "crisps")
                {
                    productPrice = 1.5;
                }
                else if (product == "soda")
                {
                    productPrice = 0.8;
                }
                else if (product == "coke")
                {
                    productPrice = 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    product = Console.ReadLine().ToLower();
                    continue;
                }
                if (totalMoney >= productPrice)
                {
                    Console.WriteLine($"Purchased {product}");
                    totalMoney -= productPrice;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                    product = Console.ReadLine().ToLower();
                    continue;
                }
                product = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Change: {totalMoney:F2}");
        }
    }
}
