using System;
using System.Linq;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            Console.WriteLine(GetVowels(word));
        }

        static int GetVowels(string word)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int total = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    total++;
                }
            }
            
            return total;
        }
    }
}
