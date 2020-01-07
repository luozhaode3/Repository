using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCard1
{


        public class PaperCard
        {
            public string Type { get; set; }
            public string Number { get; set; }
            public PaperCard(string strType, string strNumber)
            {
                this.Type = strType;
                this.Number = strNumber;
            }

            public string Name
            {
                get
                {
                    return string.Format("{0}{1}", this.Type, this.Number);
                }

            private set { }
        }
        }

}