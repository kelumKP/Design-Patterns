using System;

namespace AbstractFactoryPattern
{
    internal class UFOBossEnemyShip : EnemyShip
    {
        IEnemyShipFactory shipFactory;

        public UFOBossEnemyShip(IEnemyShipFactory shipFactory)
        {
            this.shipFactory = shipFactory;
        }

        public override void makeShip()
        {
            Console.WriteLine("Making boss enemy ship " + getName());
            weapon = shipFactory.addESGun();
            engine = shipFactory.addESEngine();
        }
    }
}