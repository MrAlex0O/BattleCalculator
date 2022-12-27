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
        public static double DefenceCoeff = 0.8;
        public static double RaceCoeff = 1.05;

        //base infantry: damage 10 defence 5 health 20
        //base cavalry: damage 40 defence 20 health 80
        //base siege weapon: damage 30 defence 100 health 240
        public static UnitParams ElfInfantry = new UnitParams() { Damage = 10 * RaceCoeff, Defence = 5, Health = 20 };
        public static UnitParams ElfCavalry = new UnitParams() { Damage = 40 * RaceCoeff, Defence = 20, Health = 80 };   
        public static UnitParams ElfSiegeWeapon = new UnitParams() { Damage = 300 * RaceCoeff, Defence = 100, Health = 240 };

        public static UnitParams DwarfInfantry = new UnitParams() { Damage = 10, Defence = 5 * RaceCoeff, Health = 20 };
        public static UnitParams DwarfCavalry = new UnitParams() { Damage = 40, Defence = 20 * RaceCoeff, Health = 80 };
        public static UnitParams DwarfSiegeWeapon = new UnitParams() { Damage = 300, Defence = 100 * RaceCoeff, Health = 240 };

        public static UnitParams HumanInfantry = new UnitParams() { Damage = 10, Defence = 5, Health = 20 * RaceCoeff };
        public static UnitParams HumanCavalry = new UnitParams() { Damage = 40, Defence = 20, Health = 80 * RaceCoeff };
        public static UnitParams HumanSiegeWeapon = new UnitParams() { Damage = 300, Defence = 100, Health = 240 * RaceCoeff };
    }

    public class UnitParams
    {
        public double Damage { get; set; }
        public double Defence { get; set; }
        public double Health { get; set; }
    }
}
