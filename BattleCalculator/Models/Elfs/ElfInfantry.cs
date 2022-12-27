using BattleCalculator.Models.CombatUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Models.Elfs
{
    public class ElfInfantry : Infantry
    {
        public ElfInfantry()
        {
            Health = Parameters.ElfInfantry.Health;
            Damage = Parameters.ElfInfantry.Damage;
            Defence = Parameters.ElfInfantry.Defence;//#TODO ОБРАЗЕЦ
        }
    }
}
