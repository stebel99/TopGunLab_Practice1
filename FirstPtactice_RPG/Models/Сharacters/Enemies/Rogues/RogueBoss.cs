namespace FirstPtactice_RPG.Models.Enemies.Rogues
{
    class RogueBoss:BaseEnemy
    {
        public double ChanceParry { get; set; }
        public RogueBoss()
        {
            Level = 20;
            Name = "Bad Robin";
            DPS = 175;
            Health = 1000;
            Armour = 35;
            ChanceCrit = 0.35;
            OwnExperience = 1000;
            ChanceParry = 0.3;
        }
    }
}
