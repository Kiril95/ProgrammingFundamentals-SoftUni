using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .ToList();

            bool IsChanged = false;

            while (true)
            {
                string command = Console.ReadLine();
                string[] operations = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command == "end")
                {
                    break;
                }

                switch (operations[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(operations[1]));
                        IsChanged = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(operations[1]));
                        IsChanged = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(operations[1]));
                        IsChanged = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(operations[2])
                                    , (int.Parse(operations[1])));
                        IsChanged = true;
                        break;
                    case "Contains":
                        if (numbers.Contains(int.Parse(operations[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":

                        List<int> filtered = new List<int>();

                        if (operations[1] == "<")
                        {
                            foreach (var item in numbers.Where(n => n < int.Parse(operations[2])))
                            {
                                filtered.Add(item);
                            }
                        }

                        else if (operations[1] == ">")
                        {
                            foreach (var item in numbers.Where(n => n > int.Parse(operations[2])))
                            {
                                filtered.Add(item);
                            }
                        }
                        else if (operations[1] == ">=")
                        {
                            foreach (var item in numbers.Where(n => n >= int.Parse(operations[2])))
                            {
                                filtered.Add(item);
                            }
                        }
                        else if (operations[1] == "<=")
                        {
                            foreach (var item in numbers.Where(n => n <= int.Parse(operations[2])))
                            {
                                filtered.Add(item);
                            }
                        }
                        Console.WriteLine(string.Join(" ", filtered));
                        break;
                }

            }
            if (IsChanged == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        //  static void PrintEven(List<int> numbers, string[] operations)
        //  {
        //      for (int i = 0; i < numbers.Count; i++)
        //      {
        //          if (numbers[i] % 2 == 0)
        //          {
        //              Console.Write(numbers[i] + " ");
        //          }
        //      }
        //      Console.WriteLine();
        //  }
        //
        //  static void PrintOdd(List<int> numbers, string[] operations)
        //  {
        //      for (int i = 0; i < numbers.Count; i++)
        //      {
        //          if (numbers[i] % 2 != 0)
        //          {
        //              Console.Write(numbers[i] + " ");
        //          }
        //      }
        //      Console.WriteLine();
        //  }
    }
}
