using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        AutoResetEvent autoEvent;

        public Game(List<Player> listPlayers, Display d)
        {
            this.listPlayers = listPlayers;
            display = d;
            nbPlayers = listPlayers.Count;
            stack = new Stack();
            history = new History(nbPlayers);
            lastTurn = new Dictionary<Player,Card>();
            autoEvent = new AutoResetEvent(false);
        }

        public void play()
        {
            int i_card;

            for (int round = 0; round < 15; round++)
            {
                //affiche le score des joueurs
                display.displayString("A vous de jouer !");
                foreach (Player player in listPlayers)
                {
                    display.hideCard(player);
                    display.displayScore(player, player.getScore());
                }

                //pioche une carte et l'affiche
                stack.nextCard();
                display.displayStack(stack);

                //Génere le tableau des cartes par puissance
                history.sortTabPower();

                //demande aux joueurs de jouer
                lastTurn.Clear();
                foreach (Player player in listPlayers)
                {
                    Card currentCard = player.play(stack.getCard(), history);
                    lastTurn.Add(player, currentCard);
                }

                foreach (KeyValuePair<Player, Card> entry in lastTurn)
                {
                    history.add(entry.Key, entry.Value);
                }

                //affiche les cartes jouées par tout le monde
                foreach (KeyValuePair<Player, Card> entry in lastTurn)
                {
                    display.displayCard(entry.Key, entry.Value);
                }

                //supprime les doublons
                for (int i = 0; i < lastTurn.Count; i++)
                {
                    i_card = lastTurn.ElementAt(i).Value.number;
                    for (int j = i + 1; j < lastTurn.Count; j++)
                    {
                        if (i_card == lastTurn.ElementAt(j).Value.number)
                        {
                            lastTurn.ElementAt(i).Value.number = 0;
                            lastTurn.ElementAt(j).Value.number = 0;
                        }
                    }
                }

                //cherche le joueur qui a joué la plus grande carte
                KeyValuePair<Player, Card> cartPlayed = lastTurn.ElementAt(0);
                if (stack.isMouse())
                {
                    for (int i = 1; i < lastTurn.Count; i++)
                    {
                        if (cartPlayed.Value.number < lastTurn.ElementAt(i).Value.number)
                        {
                            cartPlayed = lastTurn.ElementAt(i);
                        }
                    }
                }
                //cherche le joueur qui a joué la plus petite carte
                else
                {
                    for (int i = 1; i < lastTurn.Count; i++)
                    {
                        if (lastTurn.ElementAt(i).Value.number != 0)
                        {
                            if (cartPlayed.Value.number == 0)
                            {
                                cartPlayed = lastTurn.ElementAt(i);
                            }
                            else
                            {
                                if (cartPlayed.Value.number > lastTurn.ElementAt(i).Value.number && lastTurn.ElementAt(i).Value.number != 0)
                                {
                                    cartPlayed = lastTurn.ElementAt(i);
                                }
                            }
                        }
                    }
                }

                //s'il y a un gagnant ou un perdant
                if (cartPlayed.Value.number != 0)
                {
                    cartPlayed.Key.updateScore(stack.getCard());
                    if (stack.isVulture())
                    {
                        display.displayString("Le joueur " + cartPlayed.Key.getColor() + " reçoit le vautour " + stack.getCard().number + ".");
                    }
                    else
                    {
                        display.displayString("Le joueur " + cartPlayed.Key.getColor() + " reçoit la souris " + stack.getCard().number + ".");
                    }
                }
                else//si les joueurs ont tous joué la même carte
                {
                    display.displayString("Egalité : personne ne reçoit la carte !");
                }

                autoEvent.WaitOne();
            }

            //Affiche les scores finaux
            foreach (Player player in listPlayers)
            {
                display.hideCard(player);
                display.displayScore(player, player.getScore());
            }

            List<Player> listWinners;
            listWinners = new List<Player>();
            listWinners.Add(listPlayers.ElementAt(0));

            for (int i = 1; i < listPlayers.Count; i++)
            {
                if (listPlayers.ElementAt(i).getScore() > listWinners.ElementAt(0).getScore())
                {
                    listWinners.Clear();
                    listWinners.Add(listPlayers.ElementAt(i));
                }
                else if (listPlayers.ElementAt(i).getScore() == listWinners.ElementAt(0).getScore())
                {
                    listWinners.Add(listPlayers.ElementAt(i));
                }
            }
            display.displayWinner(listWinners);
        }

        public void wakeUp()
        {
            autoEvent.Set();
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
