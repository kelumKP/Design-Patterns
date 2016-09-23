using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface IEnemyShipFactory
    {
        IESWeapon addESGun();
        IESEngine addESEngine();
    }
}
