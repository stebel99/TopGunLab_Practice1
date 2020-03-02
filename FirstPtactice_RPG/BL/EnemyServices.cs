using FirstPtactice_RPG.BL.EnemyCollection;
using FirstPtactice_RPG.Models.Enemies;
using FirstPtactice_RPG.Models.Enemies.Beasts;
using FirstPtactice_RPG.Models.Enemies.Rogues;
using FirstPtactice_RPG.Pl;

namespace FirstPtactice_RPG.BL
{
    public class EnemyServices
    {
        EnemyCollection<BaseEnemy> enemies;

        BeastBoss beastBoss;
        RogueBoss rogueBoss;
        SkeletonBoss skeletonBoss;

        BaseEnemy baseEnemy;
        Enemies enemiesView = new Enemies();
        public void CreateEnemies(int numberDungeon)
        {
            string nameDungeon = "";
            int Lvl = 0;
            if (numberDungeon == 1)
            {
                nameDungeon = "***Sick Forest***";
            }
            else if (numberDungeon == 3)
            {
                nameDungeon = "***Robber Camp***";
            }
            else
            {
                nameDungeon = "***Graveyard***";
            }
            enemies = new EnemyCollection<BaseEnemy>();
            int quantity = 10;
            for (int i = 0; i < quantity; i++)
            {
                switch (numberDungeon)
                {
                    case 1:
                        {
                            Lvl = i + 1;
                            baseEnemy = new Beast(Lvl);
                            break;
                        }
                    case 3:
                        {
                            Lvl = i + 11;
                            baseEnemy = new Rogue(Lvl);
                            break;
                        }
                    case 5:
                        {
                            Lvl = i + 21;
                            baseEnemy = new Skeleton(Lvl);
                            break;
                        }
                    default:
                        break;
                }
                enemies.Add(baseEnemy);
                baseEnemy = null;
            }
            enemiesView.ShowEnemies(enemies, nameDungeon);
        }
        void CreateBeastBoss()
        {

        }

    }
}
