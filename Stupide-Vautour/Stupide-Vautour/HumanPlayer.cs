using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    public class HumanPlayer : Player
    {
        int currentCardPlayer;
        public HumanPlayer()
            : base()
        {
            currentCardPlayer = 0;
        }
        public override Card play(Card stack, History history)
        {
            //throw new NotImplementedException();
            while (currentCardPlayer == 0) { };
            Card cartplayed=base.listCard[currentCardPlayer];
            currentCardPlayer = 0;
            return cartplayed;
        }

        public void setCurrentCardPlayer(int n)
        {
            this.currentCardPlayer = n;
        }
    }
}
