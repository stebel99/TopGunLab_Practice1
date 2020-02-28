using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPtactice_RPG.Models.Hero
{
    abstract class BaseHero
    {
        protected sbyte MaxLevel = 75;
        protected sbyte Level { get; set; }
        protected string Name { get; set; }
        protected double DPS { get; set; } // Damage per second
        protected int Health { get; set; }
        protected int Armour { get; set; }
        protected double ChanceCrit { get; set; }
        protected int OwnExperience { get; set; }
        protected int NeededExperience { get; set; }
        public BaseHero()
        {
            Level = 1;
            OwnExperience = 0;
            NeededExperience = 100;
        }
    }

}
