using FirstPtactice_RPG.BL.EnemyCollection;
using FirstPtactice_RPG.Models.Enemies;

namespace FirstPtactice_RPG.Models.Locations.ThirdAct
{
    class GraveLocation:BaseLocation
    {
        protected EnemyCollection<Skeleton> Skeletons { get; set; }

        public GraveLocation()
        {
            LocationName = "Graveyard";
            Skeletons = new EnemyCollection<Skeleton>();
        }
    }
}
