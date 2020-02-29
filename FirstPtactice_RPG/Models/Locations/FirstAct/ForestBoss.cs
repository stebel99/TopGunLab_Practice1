using FirstPtactice_RPG.Models.Enemies.Beasts;

namespace FirstPtactice_RPG.Models.Locations.FirstAct
{
    class ForestBoss : BaseLocation
    {
        BeastBoss boss = new BeastBoss();
        public ForestBoss()
        {
            LocationName = "Forest Edge";
        }
    }
}
