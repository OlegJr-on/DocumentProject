using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProject
{
    class Title
    {
        string title = null;
        public string TitleForDoc
        {
            get
            {
                if (title == null)
                    title = "No found";

                return title;
            }
            set
            {
                this.title = value;
            }
        }
    }
}
