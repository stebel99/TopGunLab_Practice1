using FirstPtactice_RPG.BL.Abstracts;
using FirstPtactice_RPG.Models.Hero;
using FirstPtactice_RPG.Pl;
using System;

namespace FirstPtactice_RPG.BL
{
    public class HeroService : IHeroService
    {
        Archer archer;
        Warrior warrior;
        Wizard wizard;
        BaseHero hero;

        public void Start()
        {
            StartMenu startMenu = new StartMenu();
            string result = startMenu.Start();
            if (result == "1")
            {
                CreateHero();
            }
        }
        public void CreateHero()
        {
            CreateHero create = new CreateHero();
            string classResult = create.SelectHeroClassView();
            if (classResult == "1")
            {
                warrior = new Warrior();
                hero = warrior;
            }
            else if (classResult == "2")
            {
                archer = new Archer();
                hero = archer;
            }
            else if (classResult == "3")
            {
                wizard = new Wizard();
                hero = wizard;
            }
            else
            {
                return;
            }
            hero.Name = create.SelectHeroName();
            MenuNavigation();
        }
        public void MenuNavigation()
        {
            for (; ; )
            {
                MainMenu menu = new MainMenu();
                string result = menu.MainMenuView();
                if (result == "1")
                {
                    do
                    {
                        result = menu.HeroInfo(hero);

                        if (result == "1")
                        {
                            break;
                        }
                    } while (result != "1");
                }
                else if (result == "2")
                {
                    for (; ; )
                    {
                        var dungeons = menu.Dungeons();
                        if (Int32.TryParse(dungeons, out int newResult))
                        {
                            if (newResult >= 1 && newResult <= 6)
                            {
                                EnemyServices enemyServices = new EnemyServices(hero, this);
                                string nameDungeon;
                                switch (newResult)
                                {
                                    case 1:
                                    case 3:
                                    case 5:
                                        {
                                            for (;;)
                                            {
                                                nameDungeon = enemyServices.CreateEnemies(newResult);
                                                if (enemyServices.ShowEnemies(nameDungeon))
                                                {
                                                    break;
                                                }
                                            }
                                            break;

                                        }
                                    case 2:
                                    case 4:
                                    case 6:
                                        {
                                            nameDungeon = enemyServices.CreateBoss(newResult);
                                            enemyServices.ShowBoss(nameDungeon);
                                            break;
                                        }
                                    default:
                                        break;
                                }
                            }
                            else if (newResult == 7)
                            {
                                break;
                            }
                        }
                    }
                }
                else if (result == "3")
                {
                    break;
                }
            }
        }
        public void LvlUp()
        {
            if (hero.Level < hero.MaxLevel)
            {
                BaseHero oldHero = (BaseHero)hero.Clone();
                hero.Level += 1;
                hero.NeededExperience = (hero.NeededExperience * 3) / 2 + 1;
                LvlUpView lvlUpView = new LvlUpView();
                if (hero is Warrior)
                {
                    hero.Damage += 8;
                    hero.Health += 90;
                    hero.Armour += 10;
                }
                else if (hero is Archer)
                {
                    hero.Damage += 10;
                    hero.Health += 50;
                    hero.Armour += 7;
                }
                else if (hero is Wizard)
                {
                    hero.Damage += 12;
                    hero.Health += 35;
                    hero.Armour += 5;
                }
                lvlUpView.ShowNewStats(oldHero, hero);
            }
        }
    }
}