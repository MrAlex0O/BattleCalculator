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
        public void InitArmyA<T>(AbstractFactory factory, int infantryCount, int cavalryCount, int siegeWeaponsCount)
        {
            AInfantry = factory.CreateInfantry(infantryCount);
            ACavalry = factory.CreateCavalry(cavalryCount);
            ASiegeWeapons = factory.CreateSiegeWeapon(siegeWeaponsCount);
        }
        public void InitArmyB<T>(AbstractFactory factory, int infantryCount, int cavalryCount, int siegeWeaponCount)
        {
            //#TODO
            BInfantry = factory.CreateInfantry(infantryCount);
            BCavalry = factory.CreateCavalry(cavalryCount);
            BSiegeWeapons = factory.CreateSiegeWeapon(siegeWeaponCount);
        }

        public double CalculateArmyDamage(Infantry[] infantry, Cavalry[] cavalry, SiegeWeapon[] siegeWeapon)
        {
            double infantryPower = 0;
            foreach(var item in infantry)
            {
                infantryPower += item.Damage;
            }

            // #TODO
            double cavalryPower = 0;
            foreach (var item in cavalry)
            {
                cavalryPower += item.Damage;
            }

            double siegeWeaponPower = 0;
            foreach (var item in siegeWeapon)
            {
                siegeWeaponPower += item.Damage;
            }

            double totalDamage = infantryPower+cavalryPower+siegeWeaponPower; 
            return totalDamage;
        }

        public double CalculateArmyHealth(Infantry[] infantry, Cavalry[] cavalry, SiegeWeapon[] siegeWeapon)
        {
            //#TODO
            double infantryHealth = 0;
            foreach (var item in infantry)
            {
                infantryHealth += item.Health;  //added method to CombatUnits
            }

            double cavalryHealth = 0;
            foreach (var item in cavalry)
            {
                cavalryHealth += item.Health;
            }

            double siegeWeaponHealth = 0;
            foreach (var item in siegeWeapon)
            {
                siegeWeaponHealth += item.Health;
            }
            double totalHealth = infantryHealth+cavalryHealth+siegeWeaponHealth;
            return totalHealth;
        }

        public double CalculateArmyDefence(Infantry[] infantry, Cavalry[] cavalry, SiegeWeapon[] siegeWeapon)
        {
            double infantryDefence = 0;
            foreach (var item in infantry)
            {
                infantryDefence += item.Defence;
            }

            double cavalryDefence = 0;
            foreach (var item in cavalry)
            {
                cavalryDefence += item.Defence;
            }

            double siegeWeaponDefence = 0;
            foreach (var item in siegeWeapon)
            {
                siegeWeaponDefence += item.Defence;
            }

            double totalDefence = infantryDefence + cavalryDefence + siegeWeaponDefence;
            return totalDefence;
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
