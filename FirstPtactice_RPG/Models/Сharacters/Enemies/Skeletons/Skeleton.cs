namespace FirstPtactice_RPG.Models.Enemies
{
    class Skeleton : BaseEnemy
    {
        public Skeleton(int lvl):base(lvl)
        {
            Name = "Skeletron";
            DPS = Level * 10;
            Health = Level * 75;
            Armour = Level * 7;
            ChanceCrit = 0.3;
            OwnExperience = Level * 50;
        }
    }
}
