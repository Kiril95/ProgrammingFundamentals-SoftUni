using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .ToList();

            List<int> secondHand = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .ToList();

            for (int i = firstHand.Count - secondHand.Count; i <= secondHand.Count; i++)
            {
                i = 0; // Зануляваме, за да работим с първия(0) индекс
                if (firstHand.Count <= 0 || secondHand.Count <= 0)
                {
                    break;
                }

                if (firstHand[i] == secondHand[i])
                {
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }

                else if (firstHand[i] != secondHand[i])
                {
                    if (firstHand[i] > secondHand[i])
                    {
                        firstHand.Add(firstHand[i]);
                        firstHand.Add(secondHand[i]);
                        firstHand.RemoveAt(0);
                        secondHand.RemoveAt(0);
                    }

                    else if (firstHand[i] < secondHand[i])
                    {
                        secondHand.Add(secondHand[i]);
                        secondHand.Add(firstHand[i]);
                        secondHand.RemoveAt(0);
                        firstHand.RemoveAt(0);
                    }
                }
     
            }

            if (firstHand.Count > secondHand.Count)
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }

        }
    }
}
