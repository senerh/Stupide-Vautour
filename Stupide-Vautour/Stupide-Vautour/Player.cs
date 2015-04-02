using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    abstract class Player
    {
        private static int PlayerID = 0;
        public const int NB_CARD = 15;

        private int number;
        private String name;
        protected List<Card> listCard;
        private int score;

        public Player()
        {
            PlayerID++;
            number = PlayerID;
            listCard = new List<Card>();
            for (int i = 0; i < NB_CARD; i++)
            {
                listCard.Add(new Card(i + 1));
            }
            score = 0;

            switch (number)
            {
                case 1:
                    name = "ROUGE";
                    break;
                case 2:
                    name = "BLEU";
                    break;
                case 3:
                    name = "VERT";
                    break;
                case 4:
                    name = "JAUNE";
                    break;
                default:
                    name = "ORANGE";
                    break;
            }
        }

        public int getID()
        {
            return number;
        }

        public void updateScore(Card card)
        {
            score = card.getValue();
        }

        public abstract Card play(Card stack, History history);

        public void updateScore(int s)
        {
            score = score + s;
        }

        public override string ToString()
        {
            return name;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Player))
                return false;
            else
                return number == ((Player)obj).getID();
        }

        public override int GetHashCode()
        {
            return number;
        }
    }
}
