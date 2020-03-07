namespace FirstPtactice_RPG.Models.Hero
{
    class Archer : BaseHero
    {
        public double ChanceDodge { get; set; }
        public Archer()
        {
            Damage = 17;
            Health = 145;
            Armour = 3;
            ChanceCrit = 0.3;
            ChanceDodge = 0.25;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
