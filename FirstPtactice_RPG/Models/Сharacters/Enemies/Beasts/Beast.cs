namespace FirstPtactice_RPG.Models.Enemies.Beasts
{
    class Beast : BaseEnemy
    {
        public Beast(int lvl):base(lvl)
        {
            Name = "Wild Roar"; 
            Damage = Level * 6;
            Health = Level * 50;
            Armour = Level * 3;
            ChanceCrit = 0.1;
            OwnExperience = Level * 15;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}