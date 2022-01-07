using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProject
{
    class Body
    {
        string body = null;
        public string BodyForDoc
        {
            get
            {
                if (body == null)
                    body = "No found";

                return body;
            }
            set
            {
                this.body = value;
            }
        }
    }
}
