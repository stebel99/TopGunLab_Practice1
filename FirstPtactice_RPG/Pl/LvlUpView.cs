using FirstPtactice_RPG.Models.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPtactice_RPG.Pl
{
    public class LvlUpView
    {
        public void ShowNewStats(BaseHero oldHero, BaseHero newhero)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($@"***Level Up***
Level {oldHero.Level} --> {newhero.Level}
Damage {oldHero.Damage} --> {newhero.Damage}
Health {oldHero.Health} --> {newhero.Health}
Armour {oldHero.Armour} --> {newhero.Armour}
Your exp {newhero.OwnExperience}/{newhero.NeededExperience}
");
            Console.ResetColor();
            Console.Write("Press any key...");
            Console.ReadKey();
        }
    }
}
