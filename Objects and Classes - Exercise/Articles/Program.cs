using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; } 
    }
    class Edited
    {
        public Edited(string edit, string changeAuthor, string rename)
        {
            Edit = edit;
            ChangeAuthor = changeAuthor;     // Конструкторче
            Rename = rename;
        }
        public string Edit { get; set; }
        public string ChangeAuthor { get; set; }
        public string Rename { get; set; }

        public override string ToString()
        {
            return $"{Rename} {Edit} {ChangeAuthor}";
            //return string.Format(this.Rename, this.Edit, this.ChangeAuthor);  //Презаписва
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> article = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            string rename = article[0];
            string edit = article[1];
            string changeAuthor = article[2];
            Edited list = new Edited(edit, changeAuthor, rename);
            
            for (int i = 0; i < n; i++)
            {
                List<string> operations = Console.ReadLine()
                .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                string command = operations[0];
                string commands = operations[1];
                //string commands2 = operations[2];

                if (command == "Edit")     
                {
                    edit = commands;
                }   //// edit = commands + commands2.Split(" "); Съединява след това разделя

                else if (command == "ChangeAuthor")
                {
                    changeAuthor = commands;
                }

                else if (command == "Rename")
                {
                    rename = commands;
                }

            }
            Console.WriteLine($"{rename} - {edit}: {changeAuthor}");

        }

    }
}
