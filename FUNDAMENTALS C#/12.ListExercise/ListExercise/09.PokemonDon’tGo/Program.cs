using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ely likes to play Pokemon Go a lot. But Pokemon Go bankrupted … So the developers made Pokemon Don’t Go out of depression. 
            //And so Ely now plays Pokemon Don’t Go. In Pokemon Don’t Go, when you walk to a certain pokemon, those closer to you, 
            //naturally get further, and those further from you, get closer.
            //You will receive a sequence of integers, separated by spaces – the distances to the pokemons.Then you will begin receiving 
            //integers, which will correspond to indexes in that sequence.
            //When you receive an index, you must remove the element at that index from the sequence (as if you’ve captured the pokemon).
            //    • You must increase the value of all elements in the sequence, which are less or equal to the removed element, 
            //      with the value of the removed element.
            //    • You must decrease the value of all elements in the sequence, which are greater than the removed element, 
            //      with the value of the removed element.
            //If the given index is less than 0, remove the first element of the sequence, and copy the last element to its place.
            //If the given index is greater than the last index of the sequence, remove the last element from the sequence, 
            //and copy the first element to its place.
            //The increasing and decreasing of elements should be done in these cases, also. The element, whose value you should use is 
            //the removed element.
            //The program ends when the sequence has no elements(there are no pokemons left for Ely to catch).
            //        4 5 3
            //        1
            //        1
            //        0
            //                    14
            //                                The array is { 4, 5, 3 }. The index is 1.
            //                                  We remove 5, and we increase all the lower ones and decrease all higher ones.
            //                                In this case there are no higher than 5.
            //                                The result is { 9, 8 }.
            //                                The index is 1.So we remove 8, and decrease all the higher ones. 
            //                                The result is { 1 }. 
            //                                The index is 0.So we remove 1.
            //                                There are no elements left, so we print the sum of all removed elements.
            //                                5 + 8 + 1 = 14.
            //        5 10 6 3 5
            //        2
            //        4
            //        1
            //        1
            //        3
            //        0
            //        0
            //                    51
            //                                Step 1: { 11, 4, 9, 11}
            //                                Step 2: { 22, 15, 20, 22}
            //                                Step 3: { 7, 5, 7}
            //                                Step 4: { 2, 2}
            //                                Step 5: { 4, 4}
            //                                Step 6: { 8}
            //                                Step 7: { } (empty).
            //                                 Result = 6 + 11 + 15 + 5 + 2 + 4 + 8 = 51.

            List<int> pokemons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            while (pokemons.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int removedElement = pokemons[0];
                    sum += removedElement;
                    pokemons.RemoveAt(0);
                    pokemons.Insert(0, pokemons[pokemons.Count - 1]);
                    ChangeElements(pokemons, removedElement);
                }
                else if (index >= pokemons.Count)
                {
                    //If the given index is greater than the last index of the sequence, remove the last element from the sequence, 
                    //and copy the first element to its place.
                    int removedElement = pokemons[pokemons.Count - 1];
                    sum += removedElement;
                    pokemons.RemoveAt(pokemons.Count - 1);
                    pokemons.Insert(pokemons.Count, pokemons[0]);
                    ChangeElements(pokemons, removedElement);
                }
                else
                {
                    int removedElement = pokemons[index];
                    sum += removedElement;
                    pokemons.RemoveAt(index);
                    ChangeElements(pokemons, removedElement);
                }
            }

            Console.WriteLine(sum);
        }

        private static void ChangeElements(List<int> pokemons, int removedElement)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= removedElement)
                {
                    pokemons[i] += removedElement;
                }
                else
                {
                    pokemons[i] -= removedElement;
                }
            }
        }
    }
}
