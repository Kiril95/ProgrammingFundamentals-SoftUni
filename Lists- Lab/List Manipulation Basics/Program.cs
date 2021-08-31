using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .ToList();

            string command = Console.ReadLine();         
            //int operation = command[0];
            //int indexOrNum = command[1];
            //int number = command[2];

            while (command != "end")
            {
                string[] operations = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (operations[0] == "Add")
                {
                    numbers.Add(int.Parse(operations[1]));
                }

                else if (operations[0] == "Remove")
                {
                    numbers.Remove(int.Parse(operations[1]));
                }

                else if (operations[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(operations[1]));
                }

                else if (operations[0] == "Insert")
                {
                    numbers.Insert(int.Parse(operations[2])
                                 ,(int.Parse(operations[1])));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
