using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProject
{
    class Docs
    {
        Title head;
        Body corpus;
        Footer colontitul;

        private void Initialisation()
        {
            head = new Title();
            corpus = new Body();
            colontitul = new Footer();
        }

        public Docs()
        {
            Initialisation();

        }
        public string Head { private get => head.TitleForDoc; set => head.TitleForDoc = value; }
        public string Corpus { private get => corpus.BodyForDoc; set => corpus.BodyForDoc = value; }

        public void Colontitul(string owner, string client)
        {
            this.colontitul.Performer = owner;
            this.colontitul.Client = client;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            int LineLength = head.TitleForDoc.Length;

            Console.WriteLine(new string('-', 25) + " Title ".ToUpper() + new string('-', 25));
            Console.WriteLine("|" + new string(' ', 24) + head.TitleForDoc + new string(' ', 57-25-LineLength-1)+"|" + "\n"); //That borders did not move 

            LineLength = corpus.BodyForDoc.Length;
            Console.WriteLine(new string('-', 25) + " Body ".ToUpper() + new string('-', 26)); 
            Console.WriteLine("|" + new string(' ', 5) + corpus.BodyForDoc + new string(' ',57-6-LineLength-1)+"|"); // That borders did not move 

            LineLength = colontitul.Performer.Length;
            Console.WriteLine(new string('-', 25) + " Footer ".ToUpper() + new string('-', 24));
            Console.WriteLine("|" + new string(' ', 1) + " Performer: " + colontitul.Performer + new string(' ',57-2-12-LineLength-1) + "|"); // That borders did not move

            LineLength = colontitul.Client.Length;
            Console.WriteLine("|" + new string(' ', 1) + " Client: " + colontitul.Client + new string(' ',57-2-9-LineLength-1 )+"|");
            Console.WriteLine(new string('_', 57) + "\n");
        }
    }
}
