using BattleCalculator.Models.CombatUnits;
using BattleCalculator.Models.Dwarfes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Factories
{
    public class DwarfFactory : AbstractFactory
    {
        public override Cavalry[] CreateCavalry(int count)
        {
            return new DwarfCavalry[count];
        }

        public override Infantry[] CreateInfantry(int count)
        {
            return new DwarfInfantry[count];
        }

        public override SiegeWeapon[] CreateSiegeWeapon(int count)
        {
            return new DwarfSiegeWeapon[count];
        }
        public override string ToString()
        {
            return "Армия гномов";
        }
    }
}
