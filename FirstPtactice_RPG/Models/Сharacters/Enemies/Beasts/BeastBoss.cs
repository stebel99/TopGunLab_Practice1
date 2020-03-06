namespace FirstPtactice_RPG.Models.Enemies.Beasts
{
    class BeastBoss : BaseEnemy
    {
        public double ChanceParry { get; set; }
        public BeastBoss():base(1)
        {
            Level = 10;
            Name = "Erimanf Boar";
            DPH = 75;
            Health = 750;
            Armour = 35;
            ChanceCrit = 0.15;
            OwnExperience = 350;
            ChanceParry = 0.3;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
