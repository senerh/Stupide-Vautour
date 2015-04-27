using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    public class HumanPlayer : Player
    {
        AutoResetEvent autoEvent;
        Card selectedCard;
        public HumanPlayer(int numPlayer)
            : base(numPlayer)
        {
            autoEvent = new AutoResetEvent(false);
        }
        public override Card play(Card stack, History history)
        {
            autoEvent.WaitOne();
            return selectedCard;
        }

        public void selectCard(int n)
        {
            selectedCard = new Card(n);
            autoEvent.Set();
        }
    }
}
