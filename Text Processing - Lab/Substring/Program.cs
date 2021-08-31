using System;
using System.Linq;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine().ToLower();
            string sequence = Console.ReadLine();

            while (sequence.Contains(key))
            {              
                //var idx = sequence.IndexOf(key);
                //Заменя дадена дума с друга
                sequence = sequence.Replace(key, string.Empty);

            }
            Console.WriteLine(sequence);

        }
    }
}
