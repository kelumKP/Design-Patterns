namespace AbstractFactoryPattern
{
    public class UFOBossEnemyShipFactory : IEnemyShipFactory
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