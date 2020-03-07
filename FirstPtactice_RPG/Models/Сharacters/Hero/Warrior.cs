namespace FirstPtactice_RPG.Models.Hero
{
    class Warrior : BaseHero
    {
        public double BlockChance { get; set; }
        public Warrior()
        {
            Damage = 10;
            Health = 200;
            Armour = 5;
            ChanceCrit = 0.1;
            BlockChance = 0.4;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
