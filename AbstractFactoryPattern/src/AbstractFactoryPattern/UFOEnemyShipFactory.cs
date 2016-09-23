using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class UFOEnemyShipFactory : IEnemyShipFactory
    {
        public IESWeapon addESGun()
        {    
            return new ESUFOGun();     // specific to regular UFO
        }
        public IESEngine addESEngine()
        {
            return new ESUFOEngine();
        }  

    }
}
