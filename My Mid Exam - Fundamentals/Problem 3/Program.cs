using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> deck = Console.ReadLine()
                   .Split(":", StringSplitOptions.RemoveEmptyEntries)
                   .ToList();
            List<string> newDeck = new List<string>();

            string command = Console.ReadLine();

            while (command != "Ready")
            {
                string[] operations = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string act = operations[0];
                string cardName = operations[1];

                if (act == "Add")
                {
                    if (deck.Contains(cardName))
                    {
                        newDeck.Add(cardName);                    
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }

                }
                else if (act == "Insert")
                {
                    int idx = int.Parse(operations[2]);
                    if (deck.Contains(cardName) &&
                       (idx >= 0 && idx < deck.Count))
                    {
                        newDeck.Insert(idx, cardName);                      
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }

                }
                else if (act == "Remove")
                {
                    if (newDeck.Contains(cardName))
                    {
                        newDeck.Remove(cardName);                     
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }

                }
                else if (act == "Swap")
                {
                    string cardName2 = operations[2];
                    int idx = newDeck.IndexOf(cardName);
                    int idx2 = newDeck.IndexOf(cardName2);
                    //string elem = newDeck.ElementAt(idx);
                    //string elem2 = newDeck.ElementAt(idx2);

                    newDeck[idx] = cardName2;
                    newDeck[idx2] = cardName;
                }
                else 
                {
                    newDeck.Reverse();
                }
                command = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", newDeck));

        }
    }
}
