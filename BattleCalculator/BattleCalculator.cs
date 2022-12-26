using BattleCalculator.Factories;
using BattleCalculator.Models.CombatUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCalculator
{
    public class BattleCalculator
    {
        Infantry[] AInfantry, BInfantry;
        Cavalry[] ACavalry, BCavalry;
        SiegeWeapon[] ASiegeWeapons, BSiegeWeapons;
        public void InitArmyA(AbstractFactory factory, int infantryCount, int cavalryCount, int siegeWeaponsCount)
        {
            AInfantry = factory.CreateInfantry(infantryCount);
            ACavalry = factory.CreateCavalry(cavalryCount);
            ASiegeWeapons = factory.CreateSiegeWeapon(siegeWeaponsCount);
        }
        public void InitArmyB<T>(int infantryCount, int cavalryCount, int siegeWeaponsCount)
        {
            //#TODO
        }

        public double CalculateArmyDamage(Infantry[] infantry, Cavalry[] cavalry, SiegeWeapon[] siegeWeapon)
        {
            double infantryPower = 0;
            foreach(var item in infantry)
            {
                infantryPower += item.Damage;
            }

            double totalDamage = infantryPower;// + cavalryPower + ... #TODO
            return totalDamage;
        }

        public double CalculateArmyHealth(Infantry[] infantry, Cavalry[] cavalry, SiegeWeapon[] siegeWeapon)
        {
            //#TODO
            double totalHealth = 0;// + cavalryHealth + ... #TODO
            return totalHealth;
        }

        public void Battle()
        {
            /*
            1 = totalDMGA <>? totalHPB
            2 = totalDMGB <>? totalHPA
            if (1) then ... потери Б
            if (2) then ... потери А
            if (1+2) then ... ничья (все померли)
            if (не1+не2) then ... ничья (все живые)
            */
        }

    }
}
