using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToList();

            List<int> removed = new List<int>();
            //int sum = 0;
            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                //i = 0;
                int currentRemoved = 0;
                if (index < 0)
                {
                    currentRemoved = numbers[0];
                    removed.Insert(0, numbers[0]);
                    //numbers.RemoveAt(0);
                    //numbers.Insert(0, numbers.Count - 1);
                    numbers[0] = numbers[numbers.Count - 1];
                    
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (numbers[j] <= currentRemoved)
                        {
                            numbers[j] += currentRemoved;
                        }
                        else
                        {
                            numbers[j] -= currentRemoved;
                        }
                    }
                }

                else if (index >= numbers.Count)
                {
                    currentRemoved = numbers[numbers.Count - 1];
                    removed.Insert(0, numbers[numbers.Count - 1]);
                    //numbers.RemoveAt(numbers.Count - 1);
                    //numbers.Add(numbers[0]);
                    numbers[0] = numbers[numbers.Count - 1];

                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (numbers[j] <= currentRemoved)
                        {
                            numbers[j] += currentRemoved;
                        }
                        else
                        {
                            numbers[j] -= currentRemoved;
                        }
                    }
                }

                else
                {
                    currentRemoved = numbers[index];
                    //sum += removedNumberCase3;
                    removed.Insert(0, numbers[index]);
                    numbers.RemoveAt(index);

                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (numbers[j] <= currentRemoved)
                        {
                            numbers[j] += currentRemoved;
                        }
                        else
                        {
                            numbers[j] -= currentRemoved;
                        }
                    }
                }                           
            }

            Console.WriteLine($"{removed.Sum()}");
        }
    }
}
