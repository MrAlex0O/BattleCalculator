using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Models.CombatUnits
{
    public abstract class Cavalry : CombatUnit
    {
        public Cavalry()
        {
            Cost = Parameters.BaseCavalryCost;
        }
    }
}
