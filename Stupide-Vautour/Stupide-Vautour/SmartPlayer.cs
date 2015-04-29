using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    public class SmartPlayer : Player
    {
        Card min, max;
        public SmartPlayer(int numPlayer)
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

            minmax(stack, history);

            //CONTINUER
            Card playedCard;

            switch (stack.number)
            {
                case 8:  case 9: case 10:
                    if (min.number >= listCards.ElementAt(listCards.Count-1).number)
                    {
                        playedCard = listCard.ElementAt(0);
                    }
                    else if(max.number < listCards.ElementAt(listCards.Count-1).number)
                    {
                        int i = 1;
                        while (listCards.Count - i >= 0 && max.number < listCards.ElementAt(listCards.Count - i).number)
                        {
                            i++;
                        }
                        playedCard = listCards.ElementAt(listCards.Count-i+1);
                    }
                    else
                    {
                        playedCard = listCards.ElementAt(random.Next(listCards.Count * 4 / 5, listCards.Count));
                    }
                    break;
                case -5: case 7: case 6:
                    if (min.number >= listCards.ElementAt(listCards.Count * 4 / 5).number)
                    {
                        playedCard = listCard.ElementAt(0);
                    }
                    else
                    {
                        playedCard = listCards.ElementAt(random.Next(listCards.Count * 3 / 5, listCards.Count * 4 / 5));
                    }
                    break;
                case 4: case 5: case -4:
                    if (min.number >= listCards.ElementAt(listCards.Count * 3 / 5).number)
                    {
                        playedCard = listCard.ElementAt(0);
                    }
                    else
                    {
                        playedCard = listCards.ElementAt(random.Next(listCards.Count * 2 / 5, listCards.Count * 3 / 5));
                    }
                    break;
                case -2: case 3: case -3:
                    if (min.number >= listCards.ElementAt(listCards.Count * 2 / 5).number)
                    {
                        playedCard = listCard.ElementAt(0);
                    }
                    else
                    {
                        playedCard = listCards.ElementAt(random.Next(listCards.Count * 1 / 5, listCards.Count * 2 / 5));
                    }
                    break;
                case -1: case 1: case 2:
                    playedCard = listCards.ElementAt(random.Next(0, listCards.Count * 1 / 5));
                    break;
                default:
                    playedCard = null;
                    break;
            }

            base.listCard.Remove(playedCard);

            return playedCard;

        }

        private void minmax(Card stack, History history)
        {
            List<Card> listCardsOthers = new List<Card>();

            foreach (Player player in history.getListPlayer())
            {
                if (!player.Equals(this))
                {
                    foreach (Card card in history.getListCard(player))
                    {
                        if (!listCardsOthers.Contains(card))
                        {
                            listCardsOthers.Add(card);
                        }
                    }
                }
            }


            List<Card> listCards = new List<Card>();
            List<Card> l = history.getSortedCardsByPower();
            foreach (Card card in l)
            {
                if (listCardsOthers.Contains(card))
                {
                    listCards.Add(card);
                }
            }

            switch (stack.number)
            {
                case -5: case -4: case 8: case 9: case 10:
                    min = listCards.ElementAt(listCards.Count * 2 / 3);
                    max = listCards.ElementAt(listCards.Count-1);
                    break;
                case -3: case -2: case 4: case 5: case 6: case 7:
                    min = listCards.ElementAt(listCards.Count * 1 / 3);
                    max = listCards.ElementAt(listCards.Count * 2 / 3);
                    break;
                case -1: case 1: case 2: case 3:
                    min = listCards.ElementAt(0);
                    max = listCards.ElementAt(listCards.Count * 1 / 3);
                    break;
                default:
                    break;
            }
        }
    }
}
