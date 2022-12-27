using BattleCalculator.Models.CombatUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Models.Humans
{
    public class HumanInfantry : Infantry
    {
        public HumanInfantry()
        {
            Health = Parameters.HumanInfantry.Health;
            Damage = Parameters.HumanInfantry.Damage;
            Defence = Parameters.HumanInfantry.Defence;
        }
    }
}
