using BattleCalculator.Models.CombatUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Factories
{
    public abstract class AbstractFactory
    {
        public abstract Infantry[] CreateInfantry(int count);
        public abstract Cavalry[] CreateCavalry(int count);
        public abstract SiegeWeapon[] CreateSiegeWeapon(int count);
    }
}
