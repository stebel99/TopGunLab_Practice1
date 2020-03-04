using FirstPtactice_RPG.BL.EnemyCollection;
using FirstPtactice_RPG.Models.Enemies;
using FirstPtactice_RPG.Models.Enemies.Beasts;
using FirstPtactice_RPG.Models.Enemies.Rogues;
using FirstPtactice_RPG.Models.Hero;
using FirstPtactice_RPG.Models.Сharacters;
using FirstPtactice_RPG.Pl;
using System;
using System.Reflection.Emit;

namespace FirstPtactice_RPG.BL
{
    public class EnemyServices
    {
        EnemyCollection<BaseEnemy> enemies;
        BaseEnemy baseEnemy;

        readonly BaseHero hero;
        readonly HeroService heroService;
        public EnemyServices(BaseHero hero, HeroService heroService)
        {
            this.hero = hero;
            this.heroService = heroService;
        }
        readonly Enemies enemiesView = new Enemies();
        public void CreateEnemies(int numberDungeon)
        {
            string nameDungeon;
            var rnd = new Random();
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
            int lvl;
            for (int i = 0; i < quantity; i++)
            {
                switch (numberDungeon)
                {
                    case 1:
                        {
                            lvl = rnd.Next(1, 10);
                            baseEnemy = new Beast(lvl);
                            break;
                        }
                    case 3:
                        {
                            lvl = rnd.Next(11, 20);
                            baseEnemy = new Rogue(lvl);
                            break;
                        }
                    case 5:
                        {
                            lvl = rnd.Next(21, 30);
                            baseEnemy = new Skeleton(lvl);
                            break;
                        }
                    default:
                        break;
                }
                enemies.Add(baseEnemy);
                baseEnemy = null;
            }
            string result = enemiesView.ShowEnemies(enemies, nameDungeon);
            ActionWithEnemies(result, numberDungeon);
        }
        public void ActionWithEnemies(string action, int numberDungeon)
        {
            int result = Int32.Parse(action);

            if (result == enemies.Count())
            {
                CreateEnemies(numberDungeon);
            }
            else if (result == enemies.Count()+1)
            {
                return;
            }
            else if (result >= 0 && result < 10)
            {
                if (FightEnemy(enemies[result]))
                {
                    enemies.Remove(result);
                }
            }
        }
        public bool FightEnemy(BaseEnemy baseEnemy)
        {
            var fightHero = hero;

            double heroDamage;
            double enemyDamage;

            bool heroWin = false;
            for (; ; )
            {
                heroDamage = CalculationClearDamage(fightHero, baseEnemy);
                enemyDamage = CalculationClearDamage(baseEnemy, fightHero);
                baseEnemy.Health -= (int)heroDamage;
                if (baseEnemy.Health <= 0)
                {
                    heroWin = true;
                    break;
                }
                fightHero.Health -= (int)enemyDamage;
                if (fightHero.Health<=0)
                {
                    break;
                }
            }
            if (heroWin)
            {
                hero.OwnExperience += baseEnemy.OwnExperience;
                if (hero.OwnExperience>=hero.NeededExperience)
                {
                    heroService.LvlUp();
                }
            }
            return heroWin;
        }
        private double CalculationClearDamage(BaseCharacter atacker, BaseCharacter defender)
        {
            var atackerDamage = atacker.DPS * CalculationCrit(atacker);
            var rnd = new Random();
            if (atacker is Wizard)
            {
                if (((Wizard)atacker).ChanceDoubleDamage * 100 <= rnd.Next(0, 100))
                {
                    atackerDamage *= 2;
                }
            }
            if (defender is BeastBoss)
            {
                if (((BeastBoss)defender).ChanceParry * 100 <= rnd.Next(0, 100))
                {
                    atackerDamage *= 0.75;
                }
            }
            else if (defender is RogueBoss)
            {
                if (((RogueBoss)defender).ChanceParry * 100 <= rnd.Next(0, 100))
                {
                    atackerDamage *= 0.75;
                }
            }
            else if (defender is Archer)
            {
                if (((Archer)defender).ChanceDodge * 100 <= rnd.Next(0, 100))
                {
                    atackerDamage = 0;
                    return atackerDamage;
                }
            }
            else if (defender is SkeletonBoss)
            {
                if (((SkeletonBoss)defender).BlockChance * 100 <= rnd.Next(0, 100))
                {
                    atackerDamage *= 0.25;
                }
            }
            else if (defender is Warrior)
            {
                if (((Warrior)defender).BlockChance * 100 <= rnd.Next(0, 100))
                {
                    atackerDamage *= 0.25;
                }
            }
            atackerDamage -= defender.Armour;
            if (atackerDamage<0)
            {
                atackerDamage = 0;
            }
            return atackerDamage;
        }
        private double CalculationCrit(BaseCharacter character)
        {
            int crit = (int)character.ChanceCrit * 100;
            var rnd = new Random();
            int result = rnd.Next(0, 100);
            if (result > crit)
            {
                return 1.0;
            }
            else
            {
                return 1.5;
            }
        }
        public void CreateBoss(int numberDungeon)
        {
            string nameDungeon = "";
            string uniqueStats = "";
            switch (numberDungeon)
            {
                case 2:
                    {
                        nameDungeon = "***Edge Forest***";
                        uniqueStats = "ChanceParry = 30%";
                        baseEnemy = new BeastBoss();
                        break;
                    }
                case 4:
                    {
                        nameDungeon = "***Rogue Trap***";
                        uniqueStats = "ChanceParry = 30%";
                        baseEnemy = new RogueBoss();
                        break;
                    }
                case 6:
                    {
                        nameDungeon = "***Tomb***";
                        uniqueStats = "BlockChance = 50%";
                        baseEnemy = new SkeletonBoss();
                        break;
                    }
                default:
                    break;
            }
            string result = enemiesView.ShowBoss(baseEnemy, nameDungeon, uniqueStats);
        }
    }
}
