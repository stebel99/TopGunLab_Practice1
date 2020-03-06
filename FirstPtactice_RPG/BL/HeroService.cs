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
            for (; ; )
            {
                string result = startMenu.Start();
                if (result == "1")
                {
                    CreateHero();
                }
                else if (result == "2")
                {
                    break;
                }
                else
                {
                    continue;
                }
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
                string uniqueStats = null;
                string result = menu.MainMenuView();
                if (hero is Warrior)
                {
                    uniqueStats = "Chance Block = 40%";
                }
                else if (hero is Archer)
                {
                    uniqueStats = "Chance Evade = 20%";
                }
                else if (hero is Wizard)
                {
                    uniqueStats = "Chance Double Damage = 35%";
                }
                if (result == "1")
                {
                    do
                    {
                        result = menu.HeroInfo(hero, uniqueStats);

                        if (result == "1")
                        {
                            continue;
                        }
                    } while (result != "1");
                }
                else if (result == "2")
                {
                    for (; ; )
                    {
                        result = menu.Dungeons();
                        if (Int32.TryParse(result, out int newResult))
                        {
                            if (newResult >= 1 && newResult <= 6)
                            {
                                EnemyServices enemyServices = new EnemyServices(hero,this);
                                switch (newResult)
                                {
                                    case 1:
                                        {
                                            enemyServices.CreateEnemies(1);
                                            break;
                                        }
                                    case 2:
                                        {
                                            enemyServices.CreateBoss(2);
                                            break;
                                        }
                                    case 3:
                                        {
                                            enemyServices.CreateEnemies(3);
                                            break;
                                        }
                                    case 4:
                                        {
                                            enemyServices.CreateBoss(4);
                                            break;
                                        }
                                    case 5:
                                        {
                                            enemyServices.CreateEnemies(5);
                                            break;
                                        }
                                    case 6:
                                        {
                                            enemyServices.CreateBoss(6);
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
            if (hero.Level <= hero.MaxLevel)
            {
                hero.Level += 1;
                hero.NeededExperience = (hero.NeededExperience*3)/2 + 1;
                if (hero is Warrior)
                {
                    hero.DPH += 8;
                    hero.Health += 90;
                    hero.Armour += 10;
                }
                else if (hero is Archer)
                {
                    hero.DPH += 10;
                    hero.Health += 50;
                    hero.Armour += 7;
                }
                else if (hero is Wizard)
                {
                    hero.DPH += 12;
                    hero.Health += 35;
                    hero.Armour += 5;
                }
            }
        }
    }
}