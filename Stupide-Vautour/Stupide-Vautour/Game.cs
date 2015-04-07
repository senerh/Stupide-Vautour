using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    class Game
    {
        int nbPlayers;
        Stack stack;
        List<Player> listPlayers;
        History history;
        List<Turn> turn;

        public Game(List<Player> listPlayers)
        {
            this.nbPlayers = listPlayers.Count;
            stack = new Stack();
            history = new History();

            this.listPlayers = listPlayers;

            turn = new List<Turn>();
        }

        public void play()
        {
            for (int round = 1; round <= 15; round++)
            {
                //récupère une carte
                stack.nextCard();

                //joue
                turn.Clear();
                foreach (Player player in listPlayers)
                {
                    Card currentCard = player.play(stack.getCard(), history);
                    turn.Add(new Turn(player, currentCard));
                    history.add(player, currentCard);
                }

                //supprime les doublons
                for (int i = 0; i < nbPlayers; i++)
                {
                    for (int j = i + 1; j < nbPlayers; j++)
                    {
                        if (turn.ElementAt(i).getCard().number == turn.ElementAt(j).getCard().number)
                        {
                            turn.ElementAt(i).getCard().number = 0;
                            turn.ElementAt(j).getCard().number = 0;
                        }
                    }
                }

                //cherche le joueur qui a joué le max
                int max = turn.ElementAt(0).getCard().number;
                Player playerMax = turn.ElementAt(0).getPlayer();

                for (int i = 1; i < nbPlayers; i++)
                {
                    if (max < turn.ElementAt(i).getCard().number)
                    {
                        max = turn.ElementAt(i).getCard().number;
                        playerMax = turn.ElementAt(i).getPlayer();
                    }
                }

                //Il y a un gagnant
                if (max != 0)
                {
                    playerMax.updateScore(stack.getCard().number);
                }
            }
        }

        public History getHistory()
        {
            return history;
        }
    }
}
