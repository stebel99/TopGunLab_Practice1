namespace FirstPtactice_RPG.Models.Enemies.Rogues
{
    class Rogue : BaseEnemy
    {
        public Rogue(int lvl):base(lvl)
        {
            Name = "Brigand";
            Damage = Level * 10;
            Health = Level * 50;
            Armour = Level * 5;
            ChanceCrit = 0.2;
            OwnExperience = Level * 30;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
