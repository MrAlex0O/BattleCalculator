using BattleCalculator.Models.CombatUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Models.Elfs
{
    public class ElfCavalry : Cavalry
    {
        public ElfCavalry()
        {
            Health = Parameters.ElfCavalry.Health;
            Damage = Parameters.ElfCavalry.Damage;
            Defence = Parameters.ElfCavalry.Defence;
        }
    }
}
