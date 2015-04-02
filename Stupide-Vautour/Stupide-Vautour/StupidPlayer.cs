using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    class StupidPlayer : Player
    {
        public StupidPlayer()
            : base()
        {

        }
        public override Card play(Card stack, History history)
        {
            int n = new Random().Next(listCard.Count);
            Card currentCard = listCard.ElementAt(n);
            base.listCard.RemoveAt(n);
            return currentCard;
        }
    }
}
