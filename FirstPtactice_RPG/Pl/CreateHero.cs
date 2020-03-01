using System;

namespace FirstPtactice_RPG.Pl
{
    class CreateHero
    {
        public string SelectHeroClassView()
        {
            Console.Clear();
            Console.WriteLine(@"***Creating Hero***
Input class hero:
1. Warrior (Chance block - block 75% damage)
2. Archer  (Chance evade all damage)
3. Wizard  (Chance double damage)
");
            string result = Console.ReadLine();
            return result;
        }
        public string SelectHeroName()
        {
            Console.Write("Input hero name: ");
            string result = Console.ReadLine();
            return result;
        }
    }
}