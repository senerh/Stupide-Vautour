using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    public class History
    {
        private const int OCCURRENCE = 0;
        private const int POWER = 1;
        private Dictionary<Player, List<Card>> history;
        private List<Player> listPlayer;
        private int[,] tabOccurrence;
        private int nbPlayers;
        private Dictionary<int, int> dictionaryPower;//Key = card.number, value = power
        List<KeyValuePair<int, int>> listPower;

        public History(int nbPlayers)
        {
            history = new Dictionary<Player, List<Card>>();
            listPlayer = new List<Player>();
            tabOccurrence = new int[15,2];
            for (int i=0; i<15; i++)
            {
                tabOccurrence[i, OCCURRENCE] = 0;
                tabOccurrence[i, POWER] = (i + 1) * nbPlayers;
            }
            dictionaryPower = new Dictionary<int, int>();
            for (int i=0; i<15; i++)
            {
                dictionaryPower.Add(i+1, tabOccurrence[i, POWER]);
            }
            this.nbPlayers = nbPlayers;
        }

        public void add(Player player, Card card)
        {
            List<Card> list;
            if (history.ContainsKey(player))
            {
                history.TryGetValue(player, out list);
                list.Remove(card);
            }
            else
            {
                list = new List<Card>();
                for (int i = 0; i < 15; i++ )
                {
                    list.Add(new Card(i + 1));
                }
                list.Remove(card);
                history.Add(player, list);
                listPlayer.Add(player);
            }

            tabOccurrence[card.number - 1, OCCURRENCE]++;
            tabOccurrence[card.number - 1, POWER] = card.number * (nbPlayers - tabOccurrence[card.number - 1, OCCURRENCE]);

            dictionaryPower[card.number] = tabOccurrence[card.number - 1, POWER];
        }

        public List<Card> getListCard(Player player)
        {
            List<Card> list;
            history.TryGetValue(player, out list);
            return list;
        }

        public List<Player> getListPlayer()
        {
            return listPlayer;
        }

        public Dictionary<Player, List<Card>> getDictionnary()
        {
            return history;
        }

        public void clear()
        {
            history.Clear();
        }

        public void sortTabPower()
        {
            listPower = dictionaryPower.ToList();

            listPower.Sort((firstPair, nextPair) =>
            {
                return firstPair.Value.CompareTo(nextPair.Value);
            }
            );
        }

        public List<Card> getSortedCardsByPower()
        {
            List<Card> listCards = new List<Card>();
            foreach(KeyValuePair<int, int> entry in listPower)
            {
                if (entry.Value != 0)
                {
                    listCards.Add(new Card(entry.Key));
                }
            }
            return listCards;
        }
    }
}
