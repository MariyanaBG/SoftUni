using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given two hands of cards, which will be integer numbers. Assume that you have two players.
            //You have to find out the winning deck and respectively the winner.
            //You start from the beginning of both hands. Compare the cards from the first deck to the cards from the second deck.
            //The player, who has the bigger card, takes both cards and puts them at the back of his hand -the second player’s card 
            //is last, and the first person’s card(the winning one) is before it (second to last) and the player with the smaller card 
            //must remove the card from his deck. If both players’ cards have the same values - no one wins, and the two cards must be 
            //removed from the decks.The game is over, when one of the decks is left without any cards. You have to print the winner 
            //on the console and the sum of the left cards: "{First/Second} player wins! Sum: {sum}".
            //    20 30 40 50
            //    10 20 30 40
            //                        First player wins! Sum: 240
            //    10 20 30 40 50
            //    50 40 30 30 10
            //                        Second player wins! Sum: 50

            List<int> first = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            bool firstHasCards = true;
            bool secondHasCards = true;

            while (firstHasCards && secondHasCards)
            {
                if (first[0] > second[0])
                {
                    first.Add(first[0]);
                    first.RemoveAt(0);
                    first.Add(second[0]);
                    second.RemoveAt(0);
                }
                else if (first[0] < second[0])
                {
                    second.Add(second[0]);
                    second.RemoveAt(0);
                    second.Add(first[0]);
                    first.RemoveAt(0);
                }
                else
                {
                    first.RemoveAt(0);
                    second.RemoveAt(0);
                }

                if (first.Count == 0)
                {
                    firstHasCards = false;
                }

                if (second.Count == 0)
                {
                    secondHasCards = false;
                }
            }

            if (!firstHasCards)
            {
                Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
            }

            if (!secondHasCards)
            {
                Console.WriteLine($"First player wins! Sum: {first.Sum()}");
            }
        }
    }
}
