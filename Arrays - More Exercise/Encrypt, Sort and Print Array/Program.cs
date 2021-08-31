using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] sequence = new int[count];
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < sequence.Length; i++)
            {
                string word = Console.ReadLine();
                int sumVow = 0;
                int sumCon = 0;

                for (int j = 0; j < word.Length; j++)
                {
                    if (vowels.Contains(word[j]))
                    {
                        sumVow += word[j] * word.Length;
                    }
                    else
                    {
                        sumCon += word[j] / word.Length;
                    }
                }                              
                int total = sumCon + sumVow;
                sequence[i] = total;

            }

            Array.Sort(sequence);
            for (int i = 0; i < sequence.Length; i++)
            {
                Console.WriteLine(sequence[i]);
            }
        }
    }
}
