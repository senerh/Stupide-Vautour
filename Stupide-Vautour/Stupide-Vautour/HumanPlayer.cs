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
        public HumanPlayer()
            : base()
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
            autoEvent.Set();
            selectedCard = new Card(n);
        }
    }
}
