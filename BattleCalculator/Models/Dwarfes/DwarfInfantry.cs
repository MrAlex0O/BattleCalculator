using BattleCalculator.Models.CombatUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Models.Dwarfes
{
    public class DwarfInfantry : Infantry
    {
        public DwarfInfantry()
        {
            Health = Parameters.DwarfInfantry.Health;
            Damage = Parameters.DwarfInfantry.Damage;
            Defence = Parameters.DwarfInfantry.Defence;
        }
    }
}
