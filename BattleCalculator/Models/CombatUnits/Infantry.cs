using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Models.CombatUnits
{
    public abstract class Infantry : CombatUnit
    {
        public Infantry()
        {
            Cost = Parameters.BaseInfantryCost;
        }
    }
}
