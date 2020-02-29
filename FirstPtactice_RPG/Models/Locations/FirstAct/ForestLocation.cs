using FirstPtactice_RPG.BL.EnemyCollection;
using FirstPtactice_RPG.Models.Enemies.Beasts;

namespace FirstPtactice_RPG.Models.Locations.FirstAct
{

    class ForestLocation : BaseLocation
    {
        protected EnemyCollection<Beast> Beasts { get; set; }

        public ForestLocation()
        {
            LocationName = "Sick Forest";
            Beasts = new EnemyCollection<Beast>();
        }
    }
}
