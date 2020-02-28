namespace FirstPtactice_RPG.Models.Enemies.Beasts
{
    class Beast : BaseEnemy
    {
        public Beast()
        {
            Name = "Wild Roar";
            DPS = Level * 5;
            Health = Level * 50;
            Armour = Level * 1;
            ChanceCrit = 0.1;
            OwnExperience = Level * 15;
        }
    }
}
