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
                Console.WriteLine($@"{i}. {baseEnemy[i].Name} - (Lvl {baseEnemy[i].Level}) Stats: Damage = {baseEnemy[i].Damage} Health = {baseEnemy[i].Health} Exp = {baseEnemy[i].OwnExperience}
{new string('_',80)}");
            }
            Console.WriteLine($"{length}. Refresh");
            Console.Write($@"{length+1}. Back

Select action: ");
            return Console.ReadLine();
        }

        public string ShowBoss(BaseEnemy baseEnemy, string nameLocation)
        {
            Console.Clear();
            Console.WriteLine($@"{nameLocation}
{baseEnemy.Name} - (Lvl {baseEnemy.Level}) 
Stats: 
Damage        = {baseEnemy.Damage}
Health        = {baseEnemy.Health}");
            if (baseEnemy is BeastBoss)
            {
                Console.WriteLine($"Chance Parry  = {((BeastBoss)baseEnemy).ChanceParry*100}%");
            }
            else if (baseEnemy is RogueBoss)
            {
                Console.WriteLine($"Chance Parry  = {((RogueBoss)baseEnemy).ChanceParry * 100}%");
            }
            else if (baseEnemy is SkeletonBoss)
            {
                Console.WriteLine($"Block Chance  = {((SkeletonBoss)baseEnemy).BlockChance * 100}%");
            }
            Console.WriteLine($@"Exp           = {baseEnemy.OwnExperience}
{new string('_',50)}

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
And complete the game!)");
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
