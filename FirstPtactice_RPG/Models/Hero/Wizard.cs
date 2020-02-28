using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPtactice_RPG.Models.Hero
{
    class Wizard : BaseHero
    {
        public double ChanceDoubleDamage { get; set; }

        public Wizard()
        {
            DPS = 25;
            Health = 100;
            Armour = 1;
            ChanceCrit = 0.1;
            ChanceDoubleDamage = 0.3;
        }
    }

}
