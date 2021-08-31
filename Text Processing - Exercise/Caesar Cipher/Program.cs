using System;
using System.Linq;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //StringBuilder encrypted = new StringBuilder(text);
            string encrypted = string.Empty;
            int step = 3;
            foreach (var item in text)
            {
                //encrypted = encrypted.Replace(encrypted[i], (char)(encrypted[i] + (char)step));
                char value = (char)(item + (char)step);
                encrypted += value;
            }
                                                           
            Console.WriteLine(encrypted);

        }
    }
}
