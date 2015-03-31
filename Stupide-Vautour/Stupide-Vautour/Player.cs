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
        const int NB_CARD = 15;

        int number;
        String name;
        List<Card> listCard;
        int score;
        Game game;

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
        }

        public int getID()
        {
            return number;
        }

        public abstract Card play(Card stack);

        public void setGame(Game g)
        {
            game = g;
        }

        public void addScore(int s)
        {
            score = score + s;
        }

        public override string ToString()
        {
            switch (number)
            {
                case 1:
                    return "ROUGE";
                case 2:
                    return "BLEU";
                case 3:
                    return "VERT";
                case 4:
                    return "JAUNE";
                default:
                    return "ORANGE";
            }
        }
        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Player))
                return false;
            else
                return num_player == ((Player)obj).getID();
        }

        public override int GetHashCode()
        {
            return num_player;
        }
    }
}
