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
            else if (result == "2")
            {
                return;
            }
            else
            {
                Start();
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
            MainMenu menu = new MainMenu();
            string uniqueStats = null;
            string result = menu.MainMenuView();
            if(hero is Warrior)
            {
                uniqueStats = "Chance Block = 40%";
            }
            else if(hero is Archer)
            {
                uniqueStats = "Chance Evade = 20%";
            }
            else if(hero is Wizard)
            {
                uniqueStats = "Chance Double Damage = 35%";
            }
            if (result=="1")
            {
                do
                {
                    result = menu.HeroInfo(hero, uniqueStats);

                    if (result == "1")
                    {
                        MenuNavigation();
                    }
                } while (result != "1");
            }
            else if (result == "2")
            {
                result = menu.Dungeons();
                if (Int32.TryParse(result,out int newResult))
                {
                    if (newResult>=1&&newResult<=6)
                    {

                    }
                    else if(newResult==7)
                    {
                        MenuNavigation();
                    }
                }
            }
            else if (result == "3")
            {
                return;
            }
            else 
            {
                MenuNavigation();
            }

        }
        public void Figth(int indexMob)
        {
            throw new System.NotImplementedException();
        }

        public void LvlUp()
        {
            throw new System.NotImplementedException();
        }
    }
}
