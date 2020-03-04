using FirstPtactice_RPG.Models.Hero;
using System;

namespace FirstPtactice_RPG.Pl
{
    class MainMenu
    {
        public string MainMenuView()
        {
            Console.Clear();
            Console.Write(@"***Menu***
1. Hero info
2. Dungeons
3. Exit

Select action: ");
            string result = Console.ReadLine();
            return result;
        }
        public string HeroInfo(BaseHero hero, string uniqueStats)
        {
            Console.Clear();
            Console.WriteLine($@"***Hero Info***
Lvl          = {hero.Level}/{hero.MaxLevel}
Name         = {hero.Name}
DPS          = {hero.DPS}
Health       = {hero.Health}
Armour       = {hero.Armour}
Crit Chance  = {hero.ChanceCrit * 100}%
{uniqueStats}
Exp          = {hero.OwnExperience}/{hero.NeededExperience}

Select action:
1. Back
");
            string result = Console.ReadLine();
            return result;
        }
        public string Dungeons()
        {
            Console.Clear();
            Console.WriteLine(@"***Dungeons***
1. Sick Forest (Mobs lvl 1-10)
2. Forest Edge (Boss lvl 10)
3. Robber Camp (Mobs lvl 11-20)
4. Rogue Trap  (Boss lvl 20)
5. Graveyard   (Mobs lvl 21-30)
6. Tomb        (Boss lvl 30)

7. Back
");
            string result = Console.ReadLine();
            return result;
        }
    }
}
