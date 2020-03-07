namespace FirstPtactice_RPG.Models.Enemies.Rogues
{
    class RogueBoss:BaseEnemy
    {
        public double ChanceParry { get; set; }
        public RogueBoss()
        {
            Level = 20;
            Name = "Bad Robin";
            Damage = 175;
            Health = 1000;
            Armour = 120;
            ChanceCrit = 0.35;
            OwnExperience = 1000;
            ChanceParry = 0.3;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
