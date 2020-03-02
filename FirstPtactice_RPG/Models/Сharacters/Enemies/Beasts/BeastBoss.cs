namespace FirstPtactice_RPG.Models.Enemies.Beasts
{
    class BeastBoss : BaseEnemy
    {
        public double ChanceParry { get; set; }
        public BeastBoss():base(1)
        {
            Level = 10;
            Name = "Erimanf Boar";
            DPS = 75;
            Health = 750;
            Armour = 15;
            ChanceCrit = 0.15;
            OwnExperience = 350;
            ChanceParry = 0.3;
        }
    }
}
