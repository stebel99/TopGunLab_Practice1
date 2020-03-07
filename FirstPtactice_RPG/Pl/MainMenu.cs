using FirstPtactice_RPG.Models.Hero;
using System;

namespace FirstPtactice_RPG.Pl
{
    class MainMenu
    {
        public string MainMenuView()
        {
            Console.Clear();
            Console.Write(@"***   Menu   ***
1. Hero info
2. Dungeons
3. Exit

Select action: ");
            return Console.ReadLine();
        }
        public string HeroInfo(BaseHero hero)
        {
            Console.Clear();
            Console.Write($@"***   Hero Info   ***
Lvl                    = {hero.Level}/{hero.MaxLevel}
Name                   = {hero.Name}
Damage                 = {hero.Damage}
Health                 = {hero.Health}
Armour                 = {hero.Armour}
Crit Chance            = {hero.ChanceCrit * 100}%
");
            if (hero is Warrior)
            {
                Console.WriteLine($"Chance block           = {((Warrior)hero).BlockChance *100}%");
            }
            else if (hero is Archer)
            {
                Console.WriteLine($"Chance evade           = {((Archer)hero).ChanceDodge * 100}%");
            }
            else if (hero is Wizard)
            {
                Console.WriteLine($"Chance double damage   = {((Wizard)hero).ChanceDoubleDamage * 100}%");
            }
            Console.WriteLine($@"Exp                    = {hero.OwnExperience}/{hero.NeededExperience}

Select action:
1. Back
");
            return Console.ReadLine();
        }
        public string Dungeons()
        {
            Console.Clear();
            Console.WriteLine(@"***   Dungeons   ***
1. Sick Forest (Mobs lvl 1-10)
2. Forest Edge (Boss lvl 10)
3. Robber Camp (Mobs lvl 11-20)
4. Rogue Trap  (Boss lvl 20)
5. Graveyard   (Mobs lvl 21-30)
6. Tomb        (Boss lvl 30)

7. Back
");
            return Console.ReadLine();
        }
    }
}
