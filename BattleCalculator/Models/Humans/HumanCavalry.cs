using BattleCalculator.Models.CombatUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Models.Humans
{
    public class HumanCavalry : Cavalry
    {
        public HumanCavalry()
        {
            Health = Parameters.HumanCavalry.Health;
            Damage = Parameters.HumanCavalry.Damage;
            Defence = Parameters.HumanCavalry.Defence;
        }
    }
}
