using System;
using System.Collections.Generic;
using System.Linq;

namespace Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Досадна задача!
            List<string> numbers = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   //.Select(int.Parse)
                   .ToList();
            //string v = Console.ReadLine();
            //List<char> numbers = v.ToCharArray():
            int count = 0;
            string command = Console.ReadLine();

            while (command.ToLower() != "end".ToLower())
            {
                string[] operations = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int idx1 = int.Parse(operations[0]);
                int idx2 = int.Parse(operations[1]);
                count++;

                if (idx1 == idx2 || 
                    idx1 < 0 || idx1 > numbers.Count || 
                    idx2 < 0 || idx2 > numbers.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    var add = "-" + count + "a";
                    numbers.Insert(numbers.Count / 2, add);
                    numbers.Insert(numbers.Count / 2, add);
                    command = Console.ReadLine();
                    continue;
                }

                if (numbers.ElementAt(idx1).Equals(numbers.ElementAt(idx2)))
                {
                    var first = numbers.ElementAt(idx1);
                    var second = numbers.ElementAt(idx1);
                    Console.WriteLine($"Congrats! You have found matching elements" +
                        $" - {numbers.ElementAt(idx1)}!");
                    //numbers.RemoveAll(x => x == numbers.ElementAt(idx1));
                    //numbers = numbers.Where(x => x != numbers.ElementAt(idx1)).ToList();
                    // С Where помага до момента, в който има повече от 2 еднакви елемента, защото трие вс.
                    numbers.Remove(first);
                    numbers.Remove(second);
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (numbers.Count <= 0)
                {
                    Console.WriteLine($"You have won in {count} turns!");
                    return;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Sorry you lose :(" +
                $"\n{string.Join(" ",numbers)}");

        }

    }
}
