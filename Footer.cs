using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProject
{
    class Footer
    {
        string performer = null;
        string client = null;

        public string Performer
        {
            get
            {
                if (performer == null)
                    performer = "No found";

                return performer;
            }
            set
            {
                this.performer = value;
            }
        }
        public string Client
        {
            get
            {
                if (client == null)
                    client = "No found";

                return client;
            }
            set
            {
                this.client = value;
            }
        }
    }
}
