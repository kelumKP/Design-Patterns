using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class UFOEnemyShip : EnemyShip
    {

        IEnemyShipFactory shipFactory;

        public UFOEnemyShip(IEnemyShipFactory shipFactory)
        {
            this.shipFactory = shipFactory;
        }

        public override void makeShip()
        {
            Console.WriteLine("Making enemy ship " + getName());
            weapon = shipFactory.addESGun();
            engine = shipFactory.addESEngine();
        }

    }
}
