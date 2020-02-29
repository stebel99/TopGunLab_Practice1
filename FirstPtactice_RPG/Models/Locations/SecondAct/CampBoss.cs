
using FirstPtactice_RPG.Models.Enemies.Rogues;

namespace FirstPtactice_RPG.Models.Locations.SecondAct
{
    class CampBoss:BaseLocation
    {
        RogueBoss boss = new RogueBoss();
        public CampBoss()
        {
            LocationName = "Rogue Trap";
        }
    }
}
