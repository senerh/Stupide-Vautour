using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    public abstract class Player
    {
        private static int PlayerID = 0;
        public const int NB_CARD = 15;

        private int number;
        private String color;
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
                    color = "bleu";
                    break;
                case 2:
                    color = "jaune";
                    break;
                case 3:
                    color = "noir";
                    break;
                case 4:
                    color = "rouge";
                    break;
                default:
                    color = "vert";
                    break;
            }
        }

        public int getID()
        {
            return number;
        }

        public int getScore()
        {
            return score;
        }

        public void updateScore(Card card)
        {
            score += card.getValue();
        }

        public abstract Card play(Card stack, History history);

        public void updateScore(int s)
        {
            score += s;
        }

        public String getColor()
        {
            return color;
        }

        public override string ToString()
        {
            return number+":"+color;
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
