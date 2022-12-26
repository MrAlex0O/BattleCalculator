using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator.Models.CombatUnits
{
    public abstract class CombatUnit
    {
        int Cost { get; set; }
        double Damage { get; set; }
        double Defence { get; set; }
        double Movement { get; set; }
    }
}
