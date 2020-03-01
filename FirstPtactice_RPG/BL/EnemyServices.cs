using FirstPtactice_RPG.BL.EnemyCollection;
using FirstPtactice_RPG.Models.Enemies;
using FirstPtactice_RPG.Models.Enemies.Beasts;
using FirstPtactice_RPG.Models.Enemies.Rogues;

namespace FirstPtactice_RPG.BL
{
    public class EnemyServices
    {
        EnemyCollection<Beast> beasts;
        EnemyCollection<Rogue> rogues;
        EnemyCollection<Skeleton> skeletons;
        EnemyCollection<BaseEnemy> baseEnemies;

        BeastBoss beastBoss;
        RogueBoss rogueBoss;
        SkeletonBoss skeletonBoss;
        BaseEnemy baseBoss;
        void CreateCollectionMobs()
        {

        }
    }
}
