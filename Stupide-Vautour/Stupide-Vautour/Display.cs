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

        void displayPlayer(KeyValuePair<Player, Card> couple);

        void displayString(String s);
    }
}
