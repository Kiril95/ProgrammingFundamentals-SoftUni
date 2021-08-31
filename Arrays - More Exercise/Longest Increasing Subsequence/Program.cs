using System;
using System.Linq;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] list;
            int[] current = new int[numbers.Length];
            int[] prev = new int[numbers.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                // current && prev съответно = 1 && -1
                current[i] = 1;
                prev[i] = -1;

                // обхождам поредицата и сравнявам за най-добра дължина на поредица
                // if i == j -> цикъл j няма да се изпълни
                for (int j = 0; j < i; j++)
                {
                    // ако текущата стойност j/в ляво/ е по-малка от i/в дясно/
                    // && текущия брой елементи j >= броя елементи на i -> броя на елементите ще нараства
                    if (numbers[j] < numbers[i] && current[j] >= current[i])
                    {
                        current[i] = 1 + current[j];
                        prev[i] = j; // запазваме индекса на най добрия елемент
                    }
                }
                // запазвам максималния брой елементи
                if (current[i] > maxLength)
                {
                    maxLength = current[i];
                    lastIndex = i;
                }
            }
            list = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                list[i] = numbers[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(list);
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
