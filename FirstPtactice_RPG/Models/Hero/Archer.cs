using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPtactice_RPG.Models.Hero
{
    class Archer : BaseHero
    {
        public double ChanceDodge { get; set; }

        public Archer()
        {
            DPS = 17;
            Health = 145;
            Armour = 3;
            ChanceCrit = 0.3;
            ChanceDodge = 0.15;
        }
    }

}
