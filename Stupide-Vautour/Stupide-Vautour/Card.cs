using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    public class Card
    {
        public int number;

        public Card(int number)
        {
            this.number = number;
        }

        public int getValue()
        {
            return number;
        }

        public override string ToString()
        {
            return "Card " + number;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Card))
                return false;
            else
                return number == ((Card)obj).getValue();
        }

        public override int GetHashCode()
        {
            return number;
        }
    }

}