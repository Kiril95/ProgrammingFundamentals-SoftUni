using System;
using System.Text;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(Console.ReadLine()); 
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] operations = command.Split("|", StringSplitOptions.RemoveEmptyEntries);

                if (operations[0] == "Move")
                {
                    int num = int.Parse(operations[1]);
                    string subs = sb.ToString().Substring(0, num);
                    sb.Replace(subs, string.Empty);
                    sb.Append(subs);
                  
                }
                else if (operations[0] == "Insert")
                {
                    int idx = int.Parse(operations[1]);
                    string elem = operations[2];
                    sb.Insert(idx, elem);

                }
                else if (operations[0] == "ChangeAll")
                {
                    string line = operations[1];
                    string replacement = operations[2];
                    sb.Replace(line, replacement);
                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"The decrypted message is: {sb.ToString()}");

        }
    }
}
