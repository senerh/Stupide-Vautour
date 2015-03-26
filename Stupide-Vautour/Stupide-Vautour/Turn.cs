using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    class Turn
    {
        Player player;
        Card card;

        public Turn(Player p, Card c)
        {
            player = p;
            card = c;
        }

        public Player getPlayer()
        {
            return player;
        }

        public Card getCard()
        {
            return card;
        }
    }
}
