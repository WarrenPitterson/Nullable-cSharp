using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public interface ISpecialDefence
    {
        int CalculateDamageReduction(int totalDamage);
    }
}
