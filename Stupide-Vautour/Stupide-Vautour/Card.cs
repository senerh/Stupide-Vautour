using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    class Card
    {
        private int number;

        public Card(int number)
        {
            this.number = number;
        }

        public int getValue()
        {
            return number;
        }
    }

}