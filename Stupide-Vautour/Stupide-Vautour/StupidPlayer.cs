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
            List<Card> listCards = new List<Card>();
            List<Card> l = history.getSortedCardsByPower();
            foreach (Card card in l)
            {
                if (base.listCard.Contains(card))
                {
                    listCards.Add(card);
                }
            }

            Card playedCard;

            switch (stack.number)
            {
                case -5: case -4: case 8: case 9: case 10: case 7:
                    playedCard = listCards.ElementAt(random.Next(0, listCards.Count * 1 / 3));
                    break;
                case -3: case -2: case 4: case 5: case 6:
                    playedCard = listCards.ElementAt(random.Next(listCards.Count * 1 / 3, listCards.Count * 2 / 3));
                    break;
                case -1: case 1: case 2: case 3:
                    playedCard = listCards.ElementAt(random.Next(listCards.Count * 2 / 3, listCards.Count));
                    break;
                default:
                    playedCard = null;
                    break;
            }

            base.listCard.Remove(playedCard);

            return playedCard;
        }
    }
}
