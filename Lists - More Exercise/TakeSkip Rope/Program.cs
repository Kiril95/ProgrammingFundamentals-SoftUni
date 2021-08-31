using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            //List<char> digits = message.SkipWhile(x => x >= '0').TakeWhile(x => char.IsDigit(x)).ToList();
            //string digits = new String(message.Where(Char.IsDigit).ToArray());
            // Взимам числата, обаче са залепени и трябва да режа...
            //string newMessage = new String(message.Where(x => x != '-' && (x < '0' || x > '9')).ToArray());
            // Взимам всичко останало, обаче същия проблем

            List<int> digitsList = message
                .Where(x => char.IsDigit(x))
                .Select(x => x.ToString())
                .Select(int.Parse)
                .ToList();

            List<string> messageList = message
                .ToCharArray()              // Взимам всеки един символ(char), не цели индекси
                .Where(x => x < '0' || x > '9')
                .Select(x => x.ToString())
                .ToList();

            //List<int> digitsList = new List<int>();
            //List<string> messageList = new List<string>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            //for (int i = 0; i < message.Length; i++)
            //{
            //    if (char.IsDigit(message[i]))
            //    {
            //        digitsList.Add(int.Parse(message[i].ToString()));
            //    }
            //    else
            //    {
            //        messageList.Add(message[i].ToString());
            //    }
            //}

            for (int i = 0; i < digitsList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(digitsList[i]);
                }
                else
                {
                    skipList.Add(digitsList[i]);
                }
            }

            string result = string.Empty;
            int idx = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> act = messageList
                    .Skip(idx)
                    .Take(takeList[i])
                    .ToList();

                result += string.Concat(act);
                idx += takeList[i] + skipList[i];
            }

            Console.WriteLine(result);

        }
    }
}
