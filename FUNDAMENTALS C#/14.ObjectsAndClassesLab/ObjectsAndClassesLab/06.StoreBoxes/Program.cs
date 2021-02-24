using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a class Item, which contains these properties: Name and Price.
            //Define a class Box, which contains these properties: Serial Number, Item, Item Quantity and Price for a Box.
            //Until you receive "end", you will be receiving data in the following format: { Serial Number} {Item Name} {Item Quantity}
            //{ itemPrice}
            //The Price of one box has to be calculated: itemQuantity* itemPrice.
            //Print all the boxes, ordered descending by price for a box, in the following format: 
            //{ boxSerialNumber}
            //-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
            //-- ${ boxPrice}
            //    19861519 Dove 15 2.50
            //    86757035 Butter 7 3.20
            //    39393891 Orbit 16 1.60
            //    37741865 Samsung 10 1000
            //    end
            //                                37741865
            //                                -- Samsung - $1000.00: 10
            //                                -- $10000.00
            //                                19861519
            //                                -- Dove - $2.50: 15
            //                                -- $37.50
            //                                39393891
            //                                -- Orbit - $1.60: 16
            //                                -- $25.60
            //                                86757035
            //                                -- Butter - $3.20: 7
            //                                -- $22.40
            //    48760766 Alcatel 8 100
            //    97617240 Intel 2 500
            //    83840873 Milka 20 2.75
            //    35056501 SneakersXL 15 1.50
            //    end
            //                                97617240
            //                                -- Intel - $500.00: 2
            //                                -- $1000.00
            //                                48760766
            //                                -- Alcatel - $100.00: 8
            //                                -- $800.00
            //                                83840873
            //                                -- Milka - $2.75: 20
            //                                -- $55.00
            //                                35056501
            //                                -- SneakersXL - $1.50: 15
            //                                -- $22.50

            List<Box> boxes = new List<Box>();
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] token = line.Split(' ');
                string serialNumber = token[0];
                string itemName = token[1];
                int itemQuantity = int.Parse(token[2]);
                decimal itemPrice = decimal.Parse(token[3]);

                Box newBox = new Box();
                newBox.SerialNumber = serialNumber;
                newBox.Item.Name = itemName;
                newBox.Item.Price = itemPrice;
                newBox.ItemQuantity = itemQuantity;
                newBox.PriceForABox = itemQuantity * itemPrice;

                boxes.Add(newBox);

                line = Console.ReadLine();
            }

            List<Box> descandingByPrice = boxes.OrderByDescending(b => b.PriceForABox).ToList();

            for (int i = 0; i < descandingByPrice.Count; i++)
            {
                Box box = descandingByPrice[i];
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:F2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox { get; set; }
    }
}
