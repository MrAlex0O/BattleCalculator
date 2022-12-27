using BattleCalculator.Models.CombatUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Models.Dwarfes
{
    public class DwarfSiegeWeapon : SiegeWeapon
    {
        public DwarfSiegeWeapon()
        {
            Health = Parameters.DwarfSiegeWeapon.Health;
            Damage = Parameters.DwarfSiegeWeapon.Damage;
            Defence = Parameters.DwarfSiegeWeapon.Defence;
        }
    }
}
