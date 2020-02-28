﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPtactice_RPG.Models.Hero
{
    class Warrior : BaseHero
    {
        public double BlockChance { get; set; }
        public Warrior()
        {
            DPS = 10;
            Health = 200;
            Armour = 5;
            ChanceCrit = 0.1;
            BlockChance = 0.15;
        }
    }

}
