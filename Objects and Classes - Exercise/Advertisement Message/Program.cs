using System;
using System.Collections.Generic;

namespace Advertisement_Message
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<string> phrases = new List<string> { "Excellent product.", "Such a great product."
                , "I always use that product.", "Best product of its category."
                , "Exceptional product.", "I can’t live without this product." };

            List<string> events = new List<string> { "Now I feel good.", "I have succeeded with this product."
                , "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome."
                , "Try it yourself, I am very satisfied.", "I feel great!" };

            List<string> authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva"
                , "Annie", "Eva" };

            List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random phrase = new Random();
            Random occasion = new Random();
            Random writer = new Random();
            Random city = new Random();

            for (int i = 0; i < num; i++)
            {
                int phraseIdx = phrase.Next(0, phrases.Count);
                int occasionIdx = phrase.Next(0, events.Count);
                int writerIdx = phrase.Next(0, authors.Count);
                int cityIdx = phrase.Next(0, cities.Count);

                Console.WriteLine($"{phrases[phraseIdx]} {events[occasionIdx]} " +
                    $"{authors[writerIdx]} - {cities[cityIdx]}");
            }
        }
    }
}
