using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
             List<string> numbers = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .ToList();

            string command = Console.ReadLine();
            
            while (command != "3:1")
            {
                string[] operations = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int startIndex = int.Parse(operations[1]);
                int endIndexOrPartitions = int.Parse(operations[2]);
                List<string> addNames = new List<string>();

                if (operations[0] == "merge")
                {                   
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    else if (startIndex > numbers.Count - 1)
                    {
                        startIndex = numbers.Count - 1;
                    }
                    if (endIndexOrPartitions < 0)
                    {
                        endIndexOrPartitions = 0;
                    }
                    else if (endIndexOrPartitions > numbers.Count - 1)
                    {
                        endIndexOrPartitions = numbers.Count - 1;
                    }
                    
                    for (int i = startIndex; i <= endIndexOrPartitions; i++)
                    {

                        addNames.Add(numbers[i]);
                    }
                    numbers[startIndex] = string.Join("", addNames);

                    for (int i = startIndex + 1; i <= endIndexOrPartitions; i++)
                    {
                        numbers.RemoveAt(startIndex + 1);
                    }
               
                }
                else if (operations[0] == "divide")
                {
                    //List<string> temp = new List<string>();
                    string divide = numbers[int.Parse(operations[1])];
                    //int partitions = int.Parse(operations[2]);
                    int partLength = divide.Length / int.Parse(operations[2]);
                    int additionalPartLength = divide.Length % int.Parse(operations[2]);

                    for (int i = 0; i < endIndexOrPartitions; i++)
                    {
                        if (i == endIndexOrPartitions - 1)
                        {
                            partLength += additionalPartLength;
                        }

                        addNames.Add(divide.Substring(0, partLength));
                        divide = divide.Remove(0, partLength);
                    }
                    numbers.RemoveAt(int.Parse(operations[1]));
                    numbers.InsertRange(int.Parse(operations[1]), addNames);
                }

                command = Console.ReadLine();             
            }   
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
