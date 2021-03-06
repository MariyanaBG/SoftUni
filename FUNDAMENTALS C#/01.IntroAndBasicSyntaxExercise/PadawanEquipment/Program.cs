﻿using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main()
        {
            //Yoda is starting his newly created Jedi academy. So, he asked master Ivan Cho to buy the needed equipment. 
            //The number of items depends on how many students will sign up. The equipment for the Padawan contains lightsabers, 
            //belts and robes.
            //You will be given the amount of money Ivan Cho has, the number of students and the prices of each item.
            //You have to help Ivan Cho calculate if the money he has is enough to buy all of the equipment, 
            //or how much more money he needs.
            //Because the lightsabres sometimes brakes, Ivan Cho should buy 10 % more(taken from the students count), 
            //rounded up to the next integer. Also, every sixth belt is free.

            //Input / Constraints
            //The input data should be read from the console.It will consist of exactly 5 lines:
            //    • The amount of money Ivan Cho has – floating - point number in range[0.00…1, 000.00]
            //    • The count of students – integer in range[0…100]
            //    • The price of lightsabers for a single sabre – floating - point number in range[0.00…100.00]
            //    • The price of robes for a single robe – floating - point number in range[0.00…100.00]
            //    • The price of belts for a single belt – floating - point number in range[0.00…100.00]
            //The input data will always be valid.There is no need to check it explicitly.

            float amountOfMoney = float.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            float priceLightsabers = float.Parse(Console.ReadLine());
            float priceRobes = float.Parse(Console.ReadLine());
            float priceBelts = float.Parse(Console.ReadLine());

            double countOfLighsabers = Math.Ceiling((double)countOfStudents * 1.1);

            float neededMoney = (float)countOfLighsabers * priceLightsabers +
                                countOfStudents * priceRobes +
                                (countOfStudents - countOfStudents / 6) * priceBelts;

            //Output
            //The output should be printed on the console.
            //    • If the calculated price of the equipment is less or equal to the money Ivan Cho has:
            //        ◦ "The money is enough - it would cost {the cost of the equipment}lv."
            //    • If the calculated price of the equipment is more than the money Ivan Cho has:
            //        ◦  "Ivan Cho will need {neededMoney}lv more."
            //    • All prices must be rounded to two digits after the decimal point.

            if (neededMoney <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(neededMoney - amountOfMoney):F2}lv more.");
            }
        }
    }
}
