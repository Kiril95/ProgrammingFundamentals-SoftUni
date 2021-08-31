using System;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] banWord = Console.ReadLine().Split(new char[] { ':', ',', '.', '!', '*', }, StringSplitOptions.RemoveEmptyEntries);
            //Не мога да сплитна само с една \, защото това го смята за нов ред и трябва с две \\
           // string[] file = Console.ReadLine().Split(new char[] { ':', '.','\\' }
           // , StringSplitOptions.RemoveEmptyEntries);
           //
           // Console.WriteLine($"File name: {file[3]}");
           // Console.WriteLine($"File extension: {file[4]}");

            string line = Console.ReadLine();
            string[] file = line.Split('\\');
            //Първо разбирам стринга без наклонени черти
            string fileNameWithExtention = file[file.Length - 1];
            //След това взимам последните два елемента и ги доразбивам без точка
            string[] words = fileNameWithExtention.Split('.');
            string fileName = words[0];
            string extention = words[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extention}");

        }
    }
}
