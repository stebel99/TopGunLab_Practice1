using FirstPtactice_RPG.BL.EnemyCollection;
using FirstPtactice_RPG.Models.Enemies.Rogues;

namespace FirstPtactice_RPG.Models.Locations.SecondAct
{
    class CampLocation : BaseLocation
    {
        protected EnemyCollection<Rogue> Rogues { get; set; }

        public CampLocation()
        {
            LocationName = "Robber Camp";
            Rogues = new EnemyCollection<Rogue>();
        }
    }
}
