using BattleCalculator.Models.CombatUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Factories
{
    public class HumanFactory : AbstractRaceFactory
    {
        public override Cavalry[] CreateCavalry(int count)
        {
            throw new NotImplementedException();
        }

        public override Infantry[] CreateInfantry(int count)
        {
            throw new NotImplementedException();
        }

        public override SiegeWeapon[] CreateSiegeWeapon(int count)
        {
            throw new NotImplementedException();
        }
    }
}
