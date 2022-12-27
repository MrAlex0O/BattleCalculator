﻿using BattleCalculator.Models.CombatUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Models.Elfs
{
    public class ElfSiegeWeapon : SiegeWeapon
    {
        public ElfSiegeWeapon()
        {
            Health = Parameters.ElfSiegeWeapon.Health;
            Damage = Parameters.ElfSiegeWeapon.Damage;
            Defence = Parameters.ElfSiegeWeapon.Defence;
        }
    }
}
