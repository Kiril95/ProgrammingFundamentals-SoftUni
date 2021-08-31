using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] operations = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (operations[0] == "TakeOdd")
                {
                    password = password = string.Concat(password.Where((x, y) => y % 2 != 0));
                    Console.WriteLine(password);
                }
                else if (operations[0] == "Cut")
                {
                    int idx = int.Parse(operations[1]);
                    int length = int.Parse(operations[2]);
                    password = password.Remove(idx, length);
                    //string subs = password.Substring(idx, length);
                    //password = password.Replace(subs, string.Empty);

                    Console.WriteLine(password);
                }
                else if (operations[0] == "Substitute")
                {
                    string str = operations[1];
                    string repl = operations[2];
                    if (password.Contains(str))
                    {
                        password = password.Replace(str, repl);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");

        }
    }
}
