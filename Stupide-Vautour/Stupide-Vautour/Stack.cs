using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    class Stack
    {
        List<Card> listCard;
        Card currentCard;

        public Stack()
        {
            listCard = new List<Card>();
            for (int i = -5; i <= -1; i++)
            {
                listCard.Add(new Card(i));
            }
            for (int i = 1; i <= 10; i++)
            {
                listCard.Add(new Card(i));
            }
        }

        public void nextCard()
        {
            int n = new Random().Next(listCard.Count);
            currentCard = listCard.ElementAt(n);
            listCard.RemoveAt(n);
        }

        public Card getCard()
        {
            return currentCard;
        }
        public bool isMouse()
        {
            return currentCard.getValue() > 0;
        }
        public bool isVulture()
        {
            return currentCard.getValue() < 0;
        }
    }
}
