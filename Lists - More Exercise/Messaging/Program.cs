using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string message = Console.ReadLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];
                int index = GetIdx(currentNum);

                char currentChar = GetCharValue(index, message);
                Console.Write(currentChar);

                int realIndex = GetFinalIdx(index, message);
                                        // Премахвам елемента на дадения индекс и презаписвам новия стринг
                                        // Трябва , 1 за да не изтрия целия стринг, а само една буква 
                string newMessage = message.Remove(realIndex, 1); 
                message = newMessage;
            }
        }

        static int GetIdx(int number)
        {
            int index = 0;
            while (number > 0)
            {
                int currentNumber = number % 10; // Взимам дадено число(множество) от масива и 
                                                 // започвам да режа и събирам последните числа oт него
                index += currentNumber;
                number /= 10;
            }

            return index;
        }
        static char GetCharValue(int index, string message)
        {
            int countIndex = 0;  

            for (int i = 0; i < index; i++) 
            {
                countIndex++; 

                if (countIndex == message.Length)
                {
                    countIndex = 0;
                }
            }                       // Взимам Аски стойността на образувалия се индекс 

            char currentChar = message[countIndex];
            return currentChar;
        }
        static int GetFinalIdx(int index, string message)
        {
            int countIndex = 0;

            for (int i = 0; i < index; i++)
            {
                countIndex++;

                if (countIndex == message.Length)
                {
                    countIndex = 0;
                }
            }
            return countIndex;
        }
    }
}
