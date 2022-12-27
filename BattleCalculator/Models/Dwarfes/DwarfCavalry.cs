using BattleCalculator.Models.CombatUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Models.Dwarfes
{
    public class DwarfCavalry : Cavalry
    {
        public DwarfCavalry()
        {
            Health = Parameters.DwarfCavalry.Health;
            Damage = Parameters.DwarfCavalry.Damage;
            Defence = Parameters.DwarfCavalry.Defence;
        }
    }
}
