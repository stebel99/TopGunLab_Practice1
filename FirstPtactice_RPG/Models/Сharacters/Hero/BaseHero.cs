using FirstPtactice_RPG.Models.Сharacters;
namespace FirstPtactice_RPG.Models.Hero
{
    abstract class BaseHero : BaseCharacter
    {
        public int NeededExperience { get; set; }
        public BaseHero()
        {
            Level = 1;
            OwnExperience = 0;
            NeededExperience = 100;
        }
    }
}