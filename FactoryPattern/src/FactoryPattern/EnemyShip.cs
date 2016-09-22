using System;

namespace FactoryPattern
{
    public abstract class EnemyShip
    {
        private string name;
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
    }
}
