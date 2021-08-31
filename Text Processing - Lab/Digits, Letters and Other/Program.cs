using System;
using System.Text;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder diggits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();
           
            foreach (var item in text)
            {
                if (char.IsDigit(item))
                {
                    diggits.Append(item);
                }
                else if (char.IsLetter(item))
                {
                    letters.Append(item);
                }
                else
                {
                    symbols.Append(item);
                }

            }
            Console.WriteLine(diggits.ToString());
            Console.WriteLine(letters.ToString());
            Console.WriteLine(symbols.ToString());

        }
    }
}
