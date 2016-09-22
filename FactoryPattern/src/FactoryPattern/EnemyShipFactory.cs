namespace FactoryPattern
{
    public class EnemyShipFactory
    {
        public EnemyShip makeEnemyShip(string newShipType)
        {
            if (newShipType.Equals("U"))
            {
                return new UFOEnemyShip();
            }
            else if (newShipType.Equals("R"))
            {
                return new RocketEnemyShip();
            }

            else return null;
        }
    }
}