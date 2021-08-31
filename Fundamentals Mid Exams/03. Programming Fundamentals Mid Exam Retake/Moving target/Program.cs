using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] line = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string act = line[0];
                int idx = int.Parse(line[1]);
                int operation = int.Parse(line[2]);
              
                if (act == "Shoot")
                {
                    if (idx >= 0 && idx < targets.Count)
                    {
                        targets[idx] -= operation;
                        if (targets[idx] <= 0)
                        {
                            targets.RemoveAt(idx);
                        }
                    }                  
                }

                else if (act == "Add")
                {
                    if (idx >= 0 && idx < targets.Count)
                    {
                        targets.Insert(idx, operation);                    
                        //continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }

                else if (act == "Strike")
                {
                    if (idx + operation < targets.Count || idx - operation >= 0)
                    {
                        //targets.RemoveRange(idx + 1, operation);
                        targets.RemoveRange(idx - operation, operation * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                                
                }
                command = Console.ReadLine();

            }
            Console.WriteLine(string.Join("|", targets));

        }
    }
}
