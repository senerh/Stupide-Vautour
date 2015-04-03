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
        int selectedCard;
        public HumanPlayer() : base()
        {
            isSelected = false;
        }
        public override Card play(Card stack, History history)
        {
            while (!isSelected)
                ;
            isSelected = false;
            return base.listCard.ElementAt(selectedCard);
        }

        public void selectCard(int n)
        {
            isSelected = true;
            selectedCard = n;
        }
    }
}
