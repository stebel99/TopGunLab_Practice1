using System;

namespace FirstPtactice_RPG.Models.Сharacters
{
    public abstract class BaseCharacter : ICloneable
    {
        public sbyte MaxLevel = 30;
        public int Level { get; set; }
        public string Name { get; set; }
        public double DPH { get; set; } // Damage per hit
        public int Health { get; set; }
        public int Armour { get; set; }
        public double ChanceCrit { get; set; }
        public int OwnExperience { get; set; }
        public abstract object Clone();
    }
}