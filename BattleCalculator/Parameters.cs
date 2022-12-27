using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator
{
    public static class Parameters
    {
        public static int BaseArmyCost = 1500;
        public static int BaseInfantryCost = 10;
        public static int BaseCavalryCost = 50;
        public static int BaseSiegeWeaponCost = 200;
        public static double DefenceCoeff = 0.5;

        public static UnitParams ElfInfantry = new UnitParams() { Damage = 1, Defence = 0, Health = 0 };
        public static UnitParams ElfCavalry = new UnitParams() { Damage = 0, Defence = 0, Health = 0 };
        public static UnitParams ElfSiegeWeapon = new UnitParams() { Damage = 0, Defence = 0, Health = 0 };
        /*public static UnitParams ElfInfantry = new UnitParams() { Damage = 0, Defence = 0, Health = 0 };  #TODO
        public static UnitParams ElfCavalry = new UnitParams() { Damage = 0, Defence = 0, Health = 0 };
        public static UnitParams ElfSiegeWeapon = new UnitParams() { Damage = 0, Defence = 0, Health = 0 };
        public static UnitParams ElfInfantry = new UnitParams() { Damage = 0, Defence = 0, Health = 0 };
        public static UnitParams ElfCavalry = new UnitParams() { Damage = 0, Defence = 0, Health = 0 };
        public static UnitParams ElfSiegeWeapon = new UnitParams() { Damage = 0, Defence = 0, Health = 0 };*/
    }

    public class UnitParams
    {
        public double Damage { get; set; }
        public double Defence { get; set; }
        public double Health { get; set; }
    }
}
