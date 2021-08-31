using System;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] banWord = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '*' }, StringSplitOptions.RemoveEmptyEntries);
            string[] banList = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
        
            foreach (var item in banList)
            {
                //Съставям "думата", с която трябва да заместя старата(item)
                string replacement = new string('*', item.Length);
                text = text.Replace(item, replacement);
            }
            Console.WriteLine(text);

        }
    }
}
