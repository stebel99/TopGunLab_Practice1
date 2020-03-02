using FirstPtactice_RPG.Models.Сharacters;

namespace FirstPtactice_RPG.Models.Enemies
{
    public abstract class BaseEnemy : BaseCharacter
    {
        public BaseEnemy(int lvl)
        {
            Level = lvl;
        }
        public BaseEnemy() : this(1) { }
    }
}
