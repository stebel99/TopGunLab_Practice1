namespace FirstPtactice_RPG.Models.Enemies
{
    class SkeletonBoss : BaseEnemy
    {
        public double BlockChance { get; set; }
        public SkeletonBoss()
        {
            Level = 30;
            Name = "King Leoric";
            DPS = 300;
            Health = 3000;
            Armour = 200;
            ChanceCrit = 0.3;
            OwnExperience = 7500;
            BlockChance = 0.5;
        }
    }
}
