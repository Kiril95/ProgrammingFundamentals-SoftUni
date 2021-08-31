using System;
using System.Linq;

namespace Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int killCount = 0;
            string command = Console.ReadLine();

            while (command != "End")
            {
                int shotIndex = int.Parse(command);
                //int idx = Array.IndexOf(numbers, shotIndex);
                //int idx = numbers.GetLength(0); // Lenght and GetLenght е едно и също
                if (shotIndex >= numbers.Length || numbers[shotIndex] == -1)
                {
                    command = Console.ReadLine();
                    continue;                       // Хващам числото, което ще го ползвам 
                                                    // за индекс и работя по него и с него
                }
                       
                int temp = numbers[shotIndex];
                numbers[shotIndex] = -1;
                killCount++;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] <= temp)
                    {
                        if (numbers[i] != -1)
                        {
                            numbers[i] += temp;
                        }
                    }
                    else
                    {
                        if (numbers[i] != -1)
                        {
                            numbers[i] -= temp;
                        }
                    }
                }
                                          
                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {killCount} -> {string.Join(" ", numbers)}");

        }
    }
}
