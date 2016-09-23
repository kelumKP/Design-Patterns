using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Program
    {
        public void Main(string[] args)
        {
            EnemyShipBuilding MakeUFOs = new UFOEnemyShipBuilding();

            EnemyShip theGrunt = MakeUFOs.orderTheShip("UFO");
            Console.WriteLine( theGrunt + "\n");

            EnemyShip theBoss = MakeUFOs.orderTheShip("UFO BOSS");
            Console.WriteLine(theBoss + "\n");

        }
    }
}
