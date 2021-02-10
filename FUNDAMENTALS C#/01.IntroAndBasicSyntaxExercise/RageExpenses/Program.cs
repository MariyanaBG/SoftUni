using System;

namespace RageExpenses
{
    class Program
    {
        static void Main()
        {
            //As a MOBA challenger player, Pesho has the bad habit to trash his PC when he loses a game and rage quits.
            //His gaming setup consists of headset, mouse, keyboard and display. You will receive Pesho`s lost games count. 
            //Every second lost game, Pesho trashes his headset.
            //Every third lost game, Pesho trashes his mouse.
            //When Pesho trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            //Every second time, when he trashes his keyboard, he also trashes his display.
            //You will receive the price of each item in his gaming setup.Calculate his rage expenses for renewing his gaming equipment.

            int lostGamesCount = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            float expenses = (lostGamesCount / 2) * headsetPrice +
                             (lostGamesCount / 3) * mousePrice +
                             (lostGamesCount / 6) * keyboardPrice +
                             (lostGamesCount / 12) * displayPrice;

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
            //• As output you must print Pesho`s total expenses: "Rage expenses: {expenses} lv."
            //• Allowed working time / memory: 100ms / 16MB.
        }
    }
}
