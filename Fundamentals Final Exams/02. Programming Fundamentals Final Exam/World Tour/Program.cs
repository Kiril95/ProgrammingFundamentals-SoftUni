using System;
using System.Text.RegularExpressions;

namespace World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] operations = command.Split(":", StringSplitOptions.RemoveEmptyEntries);

                if (operations[0] == "Add Stop")
                {
                    int idx = int.Parse(operations[1]);
                    string str = operations[2];

                    if (idx >= 0 && idx < line.Length)
                    {
                        line = line.Insert(idx, str);
                    }
                    Console.WriteLine(line);

                }
                else if (operations[0] == "Remove Stop")
                {
                    int start = int.Parse(operations[1]);
                    int end = int.Parse(operations[2]);

                    if ((start >= 0 && start < line.Length) && (end >= 0 && end < line.Length))
                    {
                        //string subs = line.Substring(start, end - start);
                        //line = line.Replace(subs, "");
                        line = line.Remove(start, end - start + 1);
                    }
                    Console.WriteLine(line);

                }
                else if (operations[0] == "Switch")
                {
                    string oldOne = operations[1];
                    string newOne = operations[2];

                    if (line.Contains(oldOne))
                    {
                        //line = line.Replace(oldOne, newOne);
                        line = line = Regex.Replace(line, $@"{oldOne}", newOne);                      
                    }
                    Console.WriteLine(line);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {line}");

        }
    }
}
