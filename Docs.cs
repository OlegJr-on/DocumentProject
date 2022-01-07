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

        public Docs(/*string head,string corpus,string colontitul*/)
        {
            Initialisation();
            //this.head.TitleForDoc = head;
            //this.corpus.BodyForDoc = corpus;
            //this.colontitul.FooterForDoc = colontitul;
        }
        public string Head { private get => head.TitleForDoc; set => head.TitleForDoc = value; }
        public string Corpus { private get => corpus.BodyForDoc; set => corpus.BodyForDoc = value; }

        //private string ColontitulPerformer { set => colontitul.FooterForDoc = value; }
        public void Colontitul(string owner, string client)
        {
            this.colontitul.Performer = owner;
            this.colontitul.Client = client;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(new string('-', 20) + " Title ".ToUpper() + new string('-', 20));
            Console.WriteLine("|" + new string(' ', 19) + head.TitleForDoc + new string(' ', 19));
            Console.WriteLine(new string('_', 47));

            Console.WriteLine(new string('-', 20) + " Body ".ToUpper() + new string('-', 20)); // 
            Console.WriteLine("|" + new string(' ', 5) + corpus.BodyForDoc + new string(' ', 33)); //
            Console.WriteLine(new string('_', 47));

            Console.WriteLine(new string('-', 20) + " Footer ".ToUpper() + new string('-', 20));
            Console.WriteLine("|" + new string(' ', 1) + " Performer: " + colontitul.Performer);
            Console.WriteLine("|" + new string(' ', 1) + " Client: " + colontitul.Client);
            Console.WriteLine(new string('_', 47) + "\n");
        }
    }
}
