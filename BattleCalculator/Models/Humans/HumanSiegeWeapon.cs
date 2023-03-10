using BattleCalculator.Models.CombatUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Models.Humans
{
    public class HumanSiegeWeapon : SiegeWeapon
    {
        public HumanSiegeWeapon()
        {
            Health = Parameters.HumanSiegeWeapon.Health;
            Damage = Parameters.HumanSiegeWeapon.Damage;
            Defence = Parameters.HumanSiegeWeapon.Defence;
        }
    }
}
