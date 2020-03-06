using FirstPtactice_RPG.BL.EnemyCollection;
using FirstPtactice_RPG.Models.Enemies;
using FirstPtactice_RPG.Models.Enemies.Beasts;
using FirstPtactice_RPG.Models.Enemies.Rogues;
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
                Console.WriteLine($@"{i}. {baseEnemy[i].Name} - (Lvl {baseEnemy[i].Level}) Stats: DPH-{baseEnemy[i].DPH} Health-{baseEnemy[i].Health} Exp-{baseEnemy[i].OwnExperience}
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
            Console.WriteLine($@" {baseEnemy.Name} - (Lvl {baseEnemy.Level}) 
Stats: 
Damage per hit - {baseEnemy.DPH}
Health - {baseEnemy.Health}
{uniquestats}
Exp - {baseEnemy.OwnExperience}
{new string('-',50)}

1. Fight
2. Run Away");
            return Console.ReadLine();
        }

        public void ShowWin(BaseEnemy baseEnemy)
        {
            if (baseEnemy is BeastBoss || baseEnemy is RogueBoss)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine($@"***WIN BOSS***
You kill boss {baseEnemy.Name}
And earn {baseEnemy.OwnExperience} Experience");
                Console.ResetColor();
                Console.Write("Press any key...");
                Console.ReadKey();
            }
            else if (baseEnemy is SkeletonBoss)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine($@"***Congrats***
You kill last boss {baseEnemy.Name}
And earn {baseEnemy.OwnExperience} Experience");
                Console.ResetColor();
                Console.Write("Press any key...");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine($@"***WIN***
You kill enemy {baseEnemy.Name}
And earn {baseEnemy.OwnExperience} Experience");
                Console.ResetColor();
                Console.Write("Press any key...");
                Console.ReadKey();
            }
        }

        public void ShowLose(BaseEnemy baseEnemy)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine($@"***LOSE***
Enemy {baseEnemy.Name} kill you");
            Console.ResetColor();
            Console.Write("Press any key...");
            Console.ReadKey();
        }
    }
}
