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
        Dictionary<Player, Card> lastTurn;
        Display display;

        public Game(List<Player> listPlayers, Display d)
        {
            this.listPlayers = listPlayers;
            display = d;
            nbPlayers = listPlayers.Count;
            stack = new Stack();
            history = new History();
            lastTurn = new Dictionary<Player,Card>();
        }

        public void play()
        {
            for (int round = 0; round < 15; round++)
            {
                stack.nextCard();
                display.displayStack(stack);

                //joue
                lastTurn.Clear();
                foreach (Player player in listPlayers)
                {
                    Card currentCard = player.play(stack.getCard(), history);
                    lastTurn.Add(player, currentCard);
                    history.add(player, currentCard);
                }
                for (int i = 0; i < lastTurn.Count; i++)
                {
                    display.displayPlayer(lastTurn.ElementAt(i));
                }

                //supprime les doublons
                for (int i = 0; i < lastTurn.Count; i++)
                {
                    for (int j = i + 1; j < lastTurn.Count; j++)
                    {
                        if (lastTurn.ElementAt(i).Value.number == lastTurn.ElementAt(j).Value.number)
                        {
                            lastTurn.ElementAt(i).Value.number = 0;
                            lastTurn.ElementAt(j).Value.number = 0;
                        }
                    }
                }

                //cherche le joueur qui a joué le max
                KeyValuePair<Player, Card> max = lastTurn.ElementAt(0);
                for (int i = 1; i < lastTurn.Count; i++)
                {
                    if (max.Value.number < lastTurn.ElementAt(i).Value.number)
                    {
                        max = lastTurn.ElementAt(i);
                    }
                }

                //Il y a un gagnant
                if (max.Value.number != 0)
                {
                    max.Key.updateScore(stack.getCard().number);
                    if (stack.isVulture())
                    {
                        display.displayString("Le joueur " + max.Key.getColor() + " reçoit le vautour " + stack.getCard().number + ".");
                    }
                    else
                    {
                        display.displayString("Le joueur " + max.Key.getColor() + " reçoit la souris " + stack.getCard().number + ".");
                    }
                }
                else
                {
                    display.displayString("Egalité : personne ne reçoit la carte !");
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
