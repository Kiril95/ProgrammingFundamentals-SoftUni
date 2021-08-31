using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Pianist
{
    class Opera
    {
        public Opera(string composer, string piece)
        {
            Composer = composer;
            Piece = piece;                //Конструкторчее
        }
        public string Composer { get; set; }
        public string Piece { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Opera> result = new Dictionary<string, Opera>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string play = line[0];
                string composer = line[1];
                string piece = line[2];

                result.Add(play, new Opera(composer, piece));
            }
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] operations = command.Split("|", StringSplitOptions.RemoveEmptyEntries);

                if (operations[0] == "Add")
                {
                    string play = operations[1];
                    string composer = operations[2];
                    string piece = operations[3];

                    if (!result.ContainsKey(play))
                    {
                        result.Add(play, new Opera(composer, piece));
                        Console.WriteLine($"{play} by {composer} in {piece} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{play} is already in the collection!");
                    }
                }

                else if (operations[0] == "Remove")
                {
                    string play = operations[1];
                    if (result.ContainsKey(play))
                    {
                        result.Remove(play);
                        Console.WriteLine($"Successfully removed {play}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {play} does not exist in the collection.");
                    }
                }

                else if (operations[0] == "ChangeKey")
                {
                    string play = operations[1];
                    string piece = operations[2];

                    if (result.ContainsKey(play))
                    {
                        result[play].Piece = piece;
                        Console.WriteLine($"Changed the key of {play} to {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {play} does not exist in the collection.");
                    }
                }
                command = Console.ReadLine();

            }
            result = result
                    .OrderBy(x => x.Key)
                    .ThenBy(x => x.Value.Composer)
                    .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value.Composer}, Key: {item.Value.Piece}");
            }
        }
    }
}
