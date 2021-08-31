using System;
using System.Linq;
using System.Threading;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int[] numbers = new int[word.Length];
            int start = 0;
            if (word[0] == '-')
            {
                start = 1;
                for (int i = start; i < numbers.Length; i++)
                {
                    numbers[i] = int.Parse(word[i].ToString());
                }
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = int.Parse(word[i].ToString());
                }
            }

            //int test = Math.Abs(Convert.ToInt32(numbers));
            //var multy = Evens(numbers) * Odds(numbers);
            Console.WriteLine(Result(numbers)); 
        }

        static int Evens(int[] numbers)
        {
            //int[] evens = new int [numbers.Length];

            int evens = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    //Math.Abs(i);
                    evens += numbers[i];
                }
            }

            return evens;

        }
        static int Odds(int[] numbers)
        {
            //int[] odds = new int[numbers.Length];

            int odds = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    //Math.Abs(i);
                    odds += numbers[i];
                }
            }

            return odds;
        }

        static int Result(int[] numbers)
        {
            return Evens(numbers) * Odds(numbers);
        }
    }
}