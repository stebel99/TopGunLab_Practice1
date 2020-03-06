namespace FirstPtactice_RPG.Models.Enemies
{
    class SkeletonBoss : BaseEnemy
    {
        public double BlockChance { get; set; }
        public SkeletonBoss()
        {
            Level = 30;
            Name = "King Leoric";
            DPH = 500;
            Health = 3250;
            Armour = 250;
            ChanceCrit = 0.3;
            OwnExperience = 7500;
            BlockChance = 0.5;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
