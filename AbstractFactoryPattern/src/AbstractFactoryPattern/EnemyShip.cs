using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class EnemyShip
    {
        private string name;
        public IESWeapon weapon;
        public IESEngine engine;
        private double amtDamage;

        public string getName()
        {
            return name;
        }

        public void setName(string newName)
        {
            name = newName;
        }

        public double getDamage()
        {
            return amtDamage;
        }

        public void setDamage(double newDamage)
        {
            amtDamage = newDamage;
        }

        public void followHeroShip()
        {
            Console.WriteLine(getName() + " is following the hero ");
        }

        public void displayEnemyShip()
        {
            Console.WriteLine(getName() + " is on the screen ");
        }

        public void enemyShipShoots()
        {
            Console.WriteLine(getName() + " attacks and does " + getDamage());
        }

        public abstract void makeShip();

        public string toString()
        {
            string infoOnShip = "The " + name + " has a top speed of " + engine + " and an attack power of " + weapon;

            return infoOnShip;                       
        }


    }
}
