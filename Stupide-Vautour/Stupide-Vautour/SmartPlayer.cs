﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupide_Vautour
{
    public class SmartPlayer : Player
    {
        public SmartPlayer(int numPlayer)
            : base(numPlayer)
        {

        }
        public override Card play(Card stack, History history)
        {
            throw new NotImplementedException();
        }
    }
}
