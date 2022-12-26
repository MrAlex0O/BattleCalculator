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
            return new HumanCavalry[count];
        }

        public override Infantry[] CreateInfantry(int count)
        {
            return new HumanInfantry[count];
        }

        public override SiegeWeapon[] CreateSiegeWeapon(int count)
        {
            return new HumanSiegeWeapon[count];
        }
    }
}
