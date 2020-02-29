using FirstPtactice_RPG.Models.Enemies;

namespace FirstPtactice_RPG.Models.Locations.ThirdAct
{
    class GraveBoss: BaseLocation
    {
        SkeletonBoss boss = new SkeletonBoss();
        public GraveBoss()
        {
            LocationName = "Tomb";
        }
    }
}
