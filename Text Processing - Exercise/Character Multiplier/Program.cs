using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int total = 0;
            string word1 = input[0];
            string word2 = input[1];
            //int min = Math.Min(word1.Length, word2.Length);
            //int max = Math.Max(word1.Length, word2.Length);

            for (int i = 0; i < Math.Max(word1.Length, word2.Length); i++)
            {
                if (i < word1.Length && i < word2.Length)
                {
                    total += (char)word1[i] * (char)word2[i];
                }
                else if (i < word1.Length && i >= word2.Length)
                {
                    total += (char)word1[i];
                }
                else if (i >= word1.Length && i < word2.Length)
                {
                    total += (char)word2[i];
                }
            }

            Console.WriteLine(total);
        }

    }
}
