namespace FirstPtactice_RPG.Models.Сharacters
{
    public abstract class BaseCharacter
    {
        public sbyte MaxLevel = 30;
        public int Level { get; set; }
        public string Name { get; set; }
        public double DPS { get; set; } // Damage per second
        public int Health { get; set; }
        public int Armour { get; set; }
        public double ChanceCrit { get; set; }
        public int OwnExperience { get; set; }
    }
}