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
            ElfCavalry[] army = new ElfCavalry[count];
            for (int i = 0; i < count; i++)
            {
                army[i] = new ElfCavalry();
            }
            return army;
        }

        public override Infantry[] CreateInfantry(int count)
        {
            ElfInfantry[] army = new ElfInfantry[count];
            for(int i= 0; i< count; i++)
            {
                army[i] = new ElfInfantry();
            }
            return army;
        }

        public override SiegeWeapon[] CreateSiegeWeapon(int count)
        {
            ElfSiegeWeapon[] army = new ElfSiegeWeapon[count];
            for (int i = 0; i < count; i++)
            {
                army[i] = new ElfSiegeWeapon();
            }
            return army;
        }

        public override string ToString()
        {
            return "Армия эльфов";
        }
    }
}
