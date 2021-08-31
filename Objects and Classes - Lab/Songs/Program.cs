using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Music
    {
        private int age; // Field на пропърти-то

        public int Age
        {
            get { return age; }  // Property pattern . Контрол над класа. Propful
            set { age = value; }
        }

        //public Music(string type, string name, string time) // Конструктор
        //{
        //
        //}

        public string Type { get; set; }  // Prop
        public string Name { get; set; }
        public string Time { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

           //List<string> line = Console.ReadLine()
           //          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
           //          .ToList();

            List<Music> songs = new List<Music>();

            for (int i = 0; i < input; i++)
            {
                string[] operations = Console.ReadLine().Split("_").ToArray();

                //string type = operations[0];
                //string name = operations[1];
                //string time = operations[2];

                Music song = new Music();

                song.Type = operations[0];
                song.Name = operations[1];
                song.Time = operations[2];

                songs.Add(song);
            }
            string final = Console.ReadLine();

            if (final == "all")
            {
                foreach (Music tune in songs)
                {
                    Console.WriteLine($"{tune.Name}");
                }
            }
            else
            {
                foreach (Music tune in songs)
                {
                    if (tune.Type == final)
                    {
                       Console.WriteLine($"{tune.Name}");
                    }
                }
            }
        }
    }
}
