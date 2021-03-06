﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gabsy is Orgolt's Final Revenge charming drummer. She has a drum set but the different drums have different origins – 
            //some she bought, some are gifts, so they are all with different quality. Every day she practices on each of them, 
            //so she does damage and reduces the drum`s quality. Sometimes a drum brakes, so she needs to buy new one. 
            //Help her keep her drum set organized.
            //You will receive Gabsy's savings, the money she can spend on new drums. Next you will receive a sequence of integers, 
            //which represents the initial quality of each drum in Gabsy's drum set.
            //Until you receive the command "Hit it again, Gabsy!", you will be receiving an integer: the hit power Gabsy applies 
            //on each drum, while practicing.When the power is applied, you should decrease the value of the drum's quality 
            //with the current power.
            //When a certain drum reaches 0 quality, it breaks. Then Gabsy should buy a replacement. She needs to buy the exact same model.
            //Therefore, its quality will be the same as the initial quality of the broken drum. The price is calculated by the formula: 
            //{ initialQuality}*3. Gabsy will always replace her broken drums until the moment she can no longer afford it.
            //If she doesn't have enough money for a replacement, the broken drum is removed from the drum set.
            //When you receive the command "Hit it again, Gabsy!", the program ends and you should print the current state of the drum set. 
            //On the second line you should print the remaining money in Gabsy's savings account.

            //    1000.00
            //    58 65 33
            //    11
            //    12
            //    18
            //    10
            //    Hit it again, Gabsy!
            //                            7 14 23
            //                            Gabsy has 901.00lv.
            //    154.00
            //    55 111 3 5 8 50
            //    2
            //    50
            //    8
            //    23
            //    1
            //    Hit it again, Gabsy!
            //                            27 2 4 7
            //                            Gabsy has 10.00lv.


            double savings = double.Parse(Console.ReadLine());
            int[] initialQuality = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            List<int> currentQuality = initialQuality.ToList();

            while (command != "Hit it again, Gabsy!")
            {
                int power = int.Parse(command);

                for (int i = 0; i < currentQuality.Count; i++)
                {
                    if (power < currentQuality[i])
                    {
                        currentQuality[i] -= power;
                    }
                    else
                    {
                        if (initialQuality[i] * 3 <= savings)
                        {
                            savings -= initialQuality[i] * 3;
                            currentQuality[i] = initialQuality[i];
                        }
                        else
                        {
                            currentQuality[i] = 0;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            currentQuality.RemoveAll(n => n == 0);
            Console.WriteLine(string.Join(" ", currentQuality));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");

        }
    }
}
