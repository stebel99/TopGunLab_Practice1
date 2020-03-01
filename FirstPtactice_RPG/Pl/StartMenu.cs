using FirstPtactice_RPG.BL;
using FirstPtactice_RPG.BL.Abstracts;
using System;

namespace FirstPtactice_RPG.Pl
{
    public class StartMenu
    {
        public string Start()
        {
            HeroService heroService = new HeroService();
            Console.Clear();
           Console.WriteLine(@"Welcome to RPG
Max Lvl = 30
Kill enemies - earn exp
Kill third main boss - complete game

First of all you must create hero
Select an action:
1: Create Hero
2: Exit
");
            string result = Console.ReadLine();
            return result;
        }
    }
}
