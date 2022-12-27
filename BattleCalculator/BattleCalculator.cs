using BattleCalculator.Factories;
using BattleCalculator.Models.CombatUnits;
using BattleCalculator.Models.Elfs;
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
        public void InitArmyB(AbstractFactory factory, int infantryCount, int cavalryCount, int siegeWeaponCount)
        {
            BInfantry = factory.CreateInfantry(infantryCount);
            BCavalry = factory.CreateCavalry(cavalryCount);
            BSiegeWeapons = factory.CreateSiegeWeapon(siegeWeaponCount);
        }

        public double CalculateArmyDamage(Infantry[] infantry, Cavalry[] cavalry, SiegeWeapon[] siegeWeapon)
        {
            double infantryPower = 0;
            foreach (var item in infantry)
            {
                infantryPower += item.Damage;
            }

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

            double totalDamage = infantryPower + cavalryPower + siegeWeaponPower;
            return totalDamage;
        }

        public double CalculateArmyHealth(Infantry[] infantry, Cavalry[] cavalry, SiegeWeapon[] siegeWeapon)
        {
            double infantryHealth = 0;
            foreach (var item in infantry)
            {
                infantryHealth += item.Health;
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
            double totalHealth = infantryHealth + cavalryHealth + siegeWeaponHealth;
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
        public string Battle()
        {
            double healthA, damageA, defenceA;
            double healthB, damageB, defenceB;
            healthA = CalculateArmyHealth(AInfantry, ACavalry, ASiegeWeapons);
            healthB = CalculateArmyHealth(BInfantry, BCavalry, BSiegeWeapons);
            damageA = CalculateArmyDamage(AInfantry, ACavalry, ASiegeWeapons);
            damageB = CalculateArmyDamage(BInfantry, BCavalry, BSiegeWeapons);
            defenceA = CalculateArmyDefence(AInfantry, ACavalry, ASiegeWeapons);
            defenceB = CalculateArmyDefence(BInfantry, BCavalry, BSiegeWeapons);

            healthA += defenceA * Parameters.DefenceCoeff;
            healthB += defenceB * Parameters.DefenceCoeff;

            bool AbitesB = damageA > healthB ? true : false;
            bool BbitesA = damageB > healthA ? true : false;

            string res = "";
            if (AbitesB && BbitesA)
            {
                res = "Ничья, обе армии разгромлены";
            }
            if (!AbitesB && !BbitesA)
            {
                res = "Ничья, армии разошлись с миром";
            }
            if (AbitesB && !BbitesA)
            {
                res = "Уверенная победа армии А";
            }
            if (!AbitesB && BbitesA)
            {
                res = "Уверенная победа армии Б";
            }
            return res;
        }

    }
}
