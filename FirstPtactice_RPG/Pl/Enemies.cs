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
            Console.WriteLine($"{length}. Refresh");
            Console.Write($@"{length+1}. Back

Select action: ");
            return Console.ReadLine();
        }

        public string ShowBoss(BaseEnemy baseEnemy, string nameLocation, string uniquestats)
        {
            Console.Clear();
            Console.WriteLine($"{nameLocation}\n");
            Console.WriteLine($@"1. {baseEnemy.Name} - (Lvl {baseEnemy.Level}) 
Stats: 
DPS - {baseEnemy.DPS}
Health - {baseEnemy.Health}
{uniquestats}
Exp - {baseEnemy.OwnExperience}
{new string('-',50)}

2.Run Away");
            return Console.ReadLine();
        }
    }
}
