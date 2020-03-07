using FirstPtactice_RPG.BL.EnemyCollection;
using FirstPtactice_RPG.Models.Enemies;
using FirstPtactice_RPG.Models.Enemies.Beasts;
using FirstPtactice_RPG.Models.Enemies.Rogues;
using FirstPtactice_RPG.Models.Hero;
using FirstPtactice_RPG.Models.Сharacters;
using FirstPtactice_RPG.Pl;
using System;

namespace FirstPtactice_RPG.BL
{
    public class EnemyServices
    {
        EnemyCollection<BaseEnemy> enemies;
        BaseEnemy baseEnemy;

        readonly BaseHero _hero;
        readonly HeroService _heroService;
        public EnemyServices(BaseHero hero, HeroService heroService)
        {
            _hero = hero;
            _heroService = heroService;
        }
        readonly Enemies enemiesView = new Enemies();
        public string CreateEnemies(int numberDungeon)
        {
            string nameDungeon;
            var rnd = new Random();
            if (numberDungeon == 1)
            {
                nameDungeon = "***   Sick Forest   ***";
            }
            else if (numberDungeon == 3)
            {
                nameDungeon = "***   Robber Camp   ***";
            }
            else
            {
                nameDungeon = "***   Graveyard   ***";
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
            }
            return nameDungeon;

        }
        public bool ShowEnemies(string nameDungeon)
        {
            for (; ; )
            {
                string result = enemiesView.ShowEnemies(enemies, nameDungeon);
                if (ActionWithEnemies(result,out bool exit))
                {
                    if (exit)
                    {
                        return true;
                    }
                    break;
                }
            }
            return false;
        }
        public bool ActionWithEnemies(string action, out bool exitAction)
        {
            exitAction = false;
            if (Int32.TryParse(action, out int result))
            {
                if (result == enemies.Count())
                {
                    return true;
                }
                else if (result == enemies.Count() + 1)
                {
                    exitAction = true;
                    return true;
                }
                else if (result >= 0 && result < enemies.Count())
                {
                    if (FightEnemy(enemies[result]))
                    {
                        enemies.Remove(result);
                    }
                }
            }
            return false;
        }
        public bool FightEnemy(BaseEnemy enemy)
        {
            var fightHero = _hero.Clone();

            BaseEnemy baseEnemy = (BaseEnemy)enemy.Clone();
            double heroDamage;
            double enemyDamage;
            Random rnd = new Random();
            bool heroWin = false;
            for (; ; )
            {
                int whoHit = rnd.Next(0, 100);
                if (whoHit < 50)
                {
                    heroDamage = CalculationClearDamage((BaseCharacter)fightHero, baseEnemy);
                    baseEnemy.Health -= (int)heroDamage;
                    if (baseEnemy.Health <= 0)
                    {
                        heroWin = true;
                        break;
                    }
                }
                else
                {
                    enemyDamage = CalculationClearDamage(baseEnemy, (BaseCharacter)fightHero);
                    ((BaseCharacter)fightHero).Health -= (int)enemyDamage;
                    if (((BaseCharacter)fightHero).Health <= 0)
                    {
                        break;
                    }
                }
            }
            if (heroWin)
            {
                enemiesView.ShowWin(baseEnemy);
                _hero.OwnExperience += baseEnemy.OwnExperience;
                if (_hero.OwnExperience >= _hero.NeededExperience)
                {
                    _heroService.LvlUp();
                }
            }
            else
            {
                enemiesView.ShowLose(baseEnemy);
            }
            return heroWin;
        }
        private double CalculationClearDamage(BaseCharacter atacker, BaseCharacter defender)
        {
            var atackerDamage = atacker.Damage * CalculationCrit(atacker);
            var rnd = new Random();
            if (atacker is Wizard)
            {
                if (((Wizard)atacker).ChanceDoubleDamage * 100 >= rnd.Next(0, 100))
                {
                    atackerDamage *= 2;
                }
            }
            if (defender is BeastBoss)
            {
                if (((BeastBoss)defender).ChanceParry * 100 >= rnd.Next(0, 100))
                {
                    atackerDamage *= 0.75;
                }
            }
            else if (defender is RogueBoss)
            {
                if (((RogueBoss)defender).ChanceParry * 100 >= rnd.Next(0, 100))
                {
                    atackerDamage *= 0.75;
                }
            }
            else if (defender is Archer)
            {
                if (((Archer)defender).ChanceDodge * 100 >= rnd.Next(0, 100))
                {
                    atackerDamage = 0;
                    return atackerDamage;
                }
            }
            else if (defender is SkeletonBoss)
            {
                if (((SkeletonBoss)defender).BlockChance * 100 >= rnd.Next(0, 100))
                {
                    atackerDamage *= 0.25;
                }
            }
            else if (defender is Warrior)
            {
                if (((Warrior)defender).BlockChance * 100 >= rnd.Next(0, 100))
                {
                    atackerDamage *= 0.25;
                }
            }
            atackerDamage -= defender.Armour;
            if (atackerDamage < 0)
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
        public string CreateBoss(int numberDungeon)
        {
            string nameDungeon = "";
            switch (numberDungeon)
            {
                case 2:
                    {
                        nameDungeon = "***   Edge Forest   ***";
                        baseEnemy = new BeastBoss();
                        break;
                    }
                case 4:
                    {
                        nameDungeon = "***   Rogue Trap   ***";
                        baseEnemy = new RogueBoss();
                        break;
                    }
                case 6:
                    {
                        nameDungeon = "***   Tomb   ***";
                        baseEnemy = new SkeletonBoss();
                        break;
                    }
                default:
                    break;
            }
            return nameDungeon;
        }
        public void ShowBoss(string nameDungeon)
        {
            for (; ;)
            {
                string result = enemiesView.ShowBoss(baseEnemy, nameDungeon);
                if (ActionWithBoss(result))
                {
                    break;
                }
            } 
        }
        public bool ActionWithBoss(string action)
        {
            if (Int32.TryParse(action, out int result))
            {
                if (result == 1)
                {
                    return FightEnemy(baseEnemy);
   
                }
                if(result == 2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
