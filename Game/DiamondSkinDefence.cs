using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class DiamondSkinDefence : SpecialDefence
    {
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 2;
        }
    }
}

