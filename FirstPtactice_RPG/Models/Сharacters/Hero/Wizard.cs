namespace FirstPtactice_RPG.Models.Hero
{
    class Wizard : BaseHero
    {
        public double ChanceDoubleDamage { get; set; }
        public Wizard()
        {
            Damage = 25;
            Health = 100;
            Armour = 1;
            ChanceCrit = 0.1;
            ChanceDoubleDamage = 0.35;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
