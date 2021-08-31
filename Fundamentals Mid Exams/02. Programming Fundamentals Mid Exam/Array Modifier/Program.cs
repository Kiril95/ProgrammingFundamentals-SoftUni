using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] operations = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string act = operations[0];
                
                if (act == "swap")
                {
                    int idx1 = int.Parse(operations[1]);
                    int idx2 = int.Parse(operations[2]);
                    var elem = numbers.ElementAt(idx1);
                    numbers[idx1] = numbers[idx2];
                    numbers[idx2] = elem;

                }
                else if (act == "multiply")
                {
                    int idx1 = int.Parse(operations[1]);
                    int idx2 = int.Parse(operations[2]);
                    var newNum = numbers[idx1] * numbers[idx2];
                    numbers[idx1] = newNum;

                }
                else if (act == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i]--;
                    }
                }
                command = Console.ReadLine();

            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
