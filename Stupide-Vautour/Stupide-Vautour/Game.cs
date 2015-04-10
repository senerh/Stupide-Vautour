using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    public class Game
    {
        int nbPlayers;
        Stack stack;
        List<Player> listPlayers;
        History history;
        List<Turn> turn;
        Display display;

        public Game(List<Player> listPlayers, Display d)
        {
            this.listPlayers = listPlayers;
            display = d;
            nbPlayers = listPlayers.Count;
            stack = new Stack();
            history = new History();
            turn = new List<Turn>();
        }

        public void play()
        {
            /*
            for (int i = 0; i < 15; i++)
            {
                stack.nextCard();
                display.DisplayStack(stack);
                System.Threading.Thread.Sleep(1000);
            }*/

            for (int round = 0; round < 15; round++)
            {
                stack.nextCard();
                display.DisplayStack(stack);
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
        public Card getNextCard()
        {
            //récupère une carte
            stack.nextCard();
            return stack.getCard();
        }
        public HumanPlayer getPlayer()
        {
            return (HumanPlayer)listPlayers[0];
        }
    }
}
