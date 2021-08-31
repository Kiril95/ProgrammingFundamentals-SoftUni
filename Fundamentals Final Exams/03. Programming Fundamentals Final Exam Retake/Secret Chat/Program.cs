using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hidden = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] operations = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                if (operations[0] == "InsertSpace")
                {
                    int idx = int.Parse(operations[1]);

                    hidden = hidden.Insert(idx, " ");
                    Console.WriteLine(hidden);
                }
                else if (operations[0] == "Reverse")
                {
                    string repl = operations[1];

                    if (hidden.Contains(repl))
                    {
                        int start = hidden.IndexOf(repl);
                        int end = start + repl.Length; //
                        hidden = hidden.Remove(start, repl.Length);
                        //hidden = hidden.Replace(repl, "");
                        char[] reversed = repl.ToCharArray();
                        Array.Reverse(reversed);
                        string conv = new string(string.Join("", reversed));
                        hidden = hidden.Insert(hidden.Length, conv);

                        Console.WriteLine(hidden);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (operations[0] == "ChangeAll")
                {
                    string subs = operations[1];
                    string repl = operations[2];

                    while (hidden.Contains(subs))
                    {
                        hidden = hidden.Replace(subs, repl);

                    }
                    Console.WriteLine(hidden);
                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"You have a new text message: {hidden}");

        }
    }
}
