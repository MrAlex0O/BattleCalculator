using BattleCalculator.Models.CombatUnits;
using BattleCalculator.Models.Elfs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Factories
{
    public class ElfFactory : AbstractFactory
    {
        public override Cavalry[] CreateCavalry(int count)
        {
            return new ElfCavalry[count];
        }

        public override Infantry[] CreateInfantry(int count)
        {
            return new ElfInfantry[count];
        }

        public override SiegeWeapon[] CreateSiegeWeapon(int count)
        {
            return new ElfSiegeWeapon[count];
        }

        public override string ToString()
        {
            return "Армия эльфов"; //#TODO 
        }
    }
}
