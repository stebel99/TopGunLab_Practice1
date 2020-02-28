using FirstPtactice_RPG.Models.Сharacters;

namespace FirstPtactice_RPG.Models.Enemies
{
    abstract class BaseEnemy : BaseCharacter
    {
        public BaseEnemy(sbyte lvl)
        {
            Level = lvl;
        }
        public BaseEnemy() : this(1) { }
    }
}
