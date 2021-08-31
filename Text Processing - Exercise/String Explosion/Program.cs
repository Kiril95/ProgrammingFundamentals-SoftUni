using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //StringBuilder result = new StringBuilder(input);
            int power = 0;
            for (int i = 0; i < input.Length; i++)
            {
                
                if (input[i] == '>')
                {
                    power += int.Parse(input[i + 1].ToString());               
                }

                else if (power > 0 && input[i] != '>')
                {
                    input = input.Remove(i, 1);
                    //Премахва елементи от даден индекс (N) пъти
                    power--;
                    i--;
                }
            }

            Console.WriteLine(input);
        }       
    }
}
