﻿namespace FirstPtactice_RPG.Models.Enemies.Rogues
{
    class Rogue : BaseEnemy
    {
        public Rogue(int lvl):base(lvl)
        {
            Name = "Brigand";
            DPS = Level * 7;
            Health = Level * 50;
            Armour = Level * 2;
            ChanceCrit = 0.2;
            OwnExperience = Level * 30;
        }
    }
}
