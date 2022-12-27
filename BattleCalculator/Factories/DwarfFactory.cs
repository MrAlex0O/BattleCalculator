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
            DwarfCavalry[] army = new DwarfCavalry[count];
            for (int i = 0; i < count; i++)
            {
                army[i] = new DwarfCavalry();
            }
            return army;
        }

        public override Infantry[] CreateInfantry(int count)
        {
            DwarfInfantry[] army = new DwarfInfantry[count];
            for (int i = 0; i < count; i++)
            {
                army[i] = new DwarfInfantry();
            }
            return army;
        }

        public override SiegeWeapon[] CreateSiegeWeapon(int count)
        {
            DwarfSiegeWeapon[] army = new DwarfSiegeWeapon[count];
            for (int i = 0; i < count; i++)
            {
                army[i] = new DwarfSiegeWeapon();
            }
            return army;
        }
        public override string ToString()
        {
            return "Войско гномов";
        }
    }
}
