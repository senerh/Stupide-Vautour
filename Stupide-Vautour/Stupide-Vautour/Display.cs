using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    public interface Display
    {
        void displayStack(Stack stack);

        void displayCard(Player player, Card card);

        void displayString(String s);

        void displayScore(Player player, int score);

        void hideCard(Player player);
    }
}
