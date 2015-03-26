using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    class Card
    {
        public int number
        {
            get { return number; }
            set { number = value; }
        }
        public Card(int number)
        {
            this.number = number;
        }
    }
}
