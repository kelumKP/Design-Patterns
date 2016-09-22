using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{

    public class Program
    {
        public void Main(string[] args)
        {
            // User Input not Dynamic
            // -------------------------------------------------
            // EnemyShip ufoShip = new UFOEnemyShip();
            // doStuffEnemy(ufoShip);
            // -------------------------------------------------

            //  Dynamic User Input
            // -------------------------------------------------
            // EnemyShip theEnemy = null;
            // string enemyShipOption = "";

            // Console.WriteLine("What type of ship ? ( U / R)");

            // enemyShipOption = Console.ReadLine();

            // if (enemyShipOption == "U")
            // {
            //    theEnemy = new UFOEnemyShip();
            // }
            // else if(enemyShipOption == "R")
            // {
            //    theEnemy = new RocketEnemyShip();
            // }

            // doStuffEnemy(theEnemy);
            // -------------------------------------------------


            EnemyShipFactory shipFactory = new EnemyShipFactory();
            EnemyShip theEnemy = null;

            string enemyShipOption = "";

            Console.WriteLine("What type of ship ? ( U / R)");

            enemyShipOption = Console.ReadLine();

            if (!String.IsNullOrEmpty(enemyShipOption))
            {
                theEnemy = shipFactory.makeEnemyShip(enemyShipOption);
            }

            if (theEnemy != null)
            {
                doStuffEnemy(theEnemy);
            }

        }

        public static void doStuffEnemy(EnemyShip anEnemyShip)
        {
            anEnemyShip.displayEnemyShip();
            anEnemyShip.followHeroShip();
            anEnemyShip.enemyShipShoots();
        }
    }
}


