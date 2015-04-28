using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    public class StupidPlayer : Player
    {
        public StupidPlayer(int numPlayer)
            : base(numPlayer)
        {

        }
        public override Card play(Card stack, History history)
        {
            int n = random.Next(listCard.Count);
            Card currentCard = listCard.ElementAt(n);
            base.listCard.RemoveAt(n);
            return currentCard;
        }
    }
}
