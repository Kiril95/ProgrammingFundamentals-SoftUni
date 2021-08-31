using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            MiddleIndex(text);
        }

        static string MiddleIndex(string text)
        {
            string result = " ";
            //var test = text.Length;

            if (text.Length % 2 == 0)
            {
                result = text[text.Length / 2 - 1].ToString();
                Console.Write(result);
                int test = result.Length;
                if (test % 2 != 0)
                {
                    result = text[text.Length / 2].ToString();
                    Console.Write(result);
                    //return;
                }
            }

            else
            {
                result = text[text.Length / 2].ToString();
                Console.Write(result);
                //return;
            }

            return result;
        }
    }
}
