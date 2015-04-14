using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    public class HumanPlayer : Player
    {
        bool isSelected;
        Card selectedCard;
        public HumanPlayer()
            : base()
        {
            isSelected = false;
        }
        public override Card play(Card stack, History history)
        {
            while (!isSelected)
            {
                System.Threading.Thread.Sleep(100);
            }
            isSelected = false;
            return base.listCard.Find(selectedCard.Equals);
        }

        public void selectCard(int n)
        {
            selectedCard = new Card(n);
            isSelected = true;
        }
    }
}
