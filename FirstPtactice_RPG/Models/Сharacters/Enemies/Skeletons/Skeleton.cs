namespace FirstPtactice_RPG.Models.Enemies
{
    class Skeleton : BaseEnemy
    {
        public Skeleton(int lvl):base(lvl)
        {
            Name = "Skeletron";
            DPH = Level * 15;
            Health = Level * 75;
            Armour = Level * 9;
            ChanceCrit = 0.3;
            OwnExperience = Level * 50;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
