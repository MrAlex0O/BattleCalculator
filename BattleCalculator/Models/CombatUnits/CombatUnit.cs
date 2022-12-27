using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Models.CombatUnits
{
    public abstract class CombatUnit
    {
        public int Cost { get; set; }
        public double Damage { get; set; }
        public double Defence { get; set; }
        public double Health { get; set; }
        public CombatUnit() //added this metod
        {
            Health = BaseRace.Health;
        }
    }
}
