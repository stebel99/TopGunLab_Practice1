using FirstPtactice_RPG.BL.EnemyCollection;
using FirstPtactice_RPG.Models.Enemies;
using System;

namespace FirstPtactice_RPG.Pl
{
    public class Enemies
    {
        public string ShowEnemies(EnemyCollection<BaseEnemy> baseEnemy,string name) 
        {
            Console.Clear();
            Console.WriteLine($"{name}\n");
            int length = baseEnemy.Count();
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($@"{i}. {baseEnemy[i].Name} - (Lvl {baseEnemy[i].Level}) Stats: DPS-{baseEnemy[i].DPS} Health-{baseEnemy[i].Health} Exp-{baseEnemy[i].OwnExperience}
{new string('-',80)}");
            }
            Console.Write($@"{length}. Back
Select action: ");
            return Console.ReadLine();
        }
    }
}
