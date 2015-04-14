using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    public class History
    {
        private Dictionary<Player, List<Card>> history;
        private List<Player> listPlayer;

        public History()
        {
            history = new Dictionary<Player, List<Card>>();
            listPlayer = new List<Player>();
        }

        public void add(Player player, Card card)
        {
            List<Card> list;
            if (history.ContainsKey(player))
            {
                history.TryGetValue(player, out list);
                list.Add(card);
            }
            else
            {
                list = new List<Card>();
                list.Add(card);
                history.Add(player, list);
                listPlayer.Add(player);
            }
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
    }
}
