using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProject
{
    class User
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input data in document: ");
            Docs paper = new Docs();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(new string('-', 20) + " Title " + new string('-', 20));
            Console.Write(new string(' ', 20));

            Console.ResetColor();
            paper.Head = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(new string('-', 47));


            Console.WriteLine(new string(' ', 20) + " Body ".ToUpper());
            Console.ResetColor();
            paper.Corpus = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n" + new string('-', 20) + " Footer " + new string('-', 20));
            Console.Write("Performer: ");
            Console.ResetColor();
            string performer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Client: ");
            Console.ResetColor();
            string client = Console.ReadLine();
            paper.Colontitul(owner: performer, client: client);

            Console.WriteLine("\n\n\n" + new string(' ', 30) + " Result ".ToUpper() + new string(' ', 30));
            Console.WriteLine(new string('v', 60) + "\n\n\n");

            paper.Show();

            Console.ResetColor();
        }
    }
}

