using BattleCalculator.Models.CombatUnits;
using BattleCalculator.Models.Humans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Factories
{
    public class HumanFactory : AbstractFactory
    {
        public override Cavalry[] CreateCavalry(int count)
        {
            HumanCavalry[] army = new HumanCavalry[count];
            for (int i = 0; i < count; i++)
            {
                army[i] = new HumanCavalry();
            }
            return army;
        }

        public override Infantry[] CreateInfantry(int count)
        {
            HumanInfantry[] army = new HumanInfantry[count];
            for (int i = 0; i < count; i++)
            {
                army[i] = new HumanInfantry();
            }
            return army;
        }

        public override SiegeWeapon[] CreateSiegeWeapon(int count)
        {
            HumanSiegeWeapon[] army = new HumanSiegeWeapon[count];
            for (int i = 0; i < count; i++)
            {
                army[i] = new HumanSiegeWeapon();
            }
            return army;
        }
        public override string ToString()
        {
            return "Войско людей";
        }
    }
}
