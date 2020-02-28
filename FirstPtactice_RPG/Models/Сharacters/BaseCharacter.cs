namespace FirstPtactice_RPG.Models.Сharacters
{
    abstract class BaseCharacter
    {
        protected sbyte MaxLevel = 30;
        protected sbyte Level { get; set; }
        protected string Name { get; set; }
        protected double DPS { get; set; } // Damage per second
        protected int Health { get; set; }
        protected int Armour { get; set; }
        protected double ChanceCrit { get; set; }
        protected int OwnExperience { get; set; }
    }
}