// See https://aka.ms/new-console-template for more information
using BattleRoyale;
using System.Runtime.CompilerServices;

Enemy enemy = new Enemy(50, 50, true, 20, 0);
Fighter fighter = new Fighter(100, 100, true, "john", 20, 0);
Knight knight = new Knight(100, 100, true, "mark", 2, 10, 0);
Sorcerer sorcerer = new Sorcerer(100, 100, true, "bob", 50, 5, 10, 1000, 0, 50);

List<Combatants> combatants = new List<Combatants>();
combatants.Add(enemy);
combatants.Add(fighter);
combatants.Add(knight);
combatants.Add(sorcerer);
int numberOfBattles = 10000;
int numberOfAlive = 4;
for (int y = 0; y < numberOfBattles; y++)
{
    while (numberOfAlive > 1)
    
    {
        for (int i = 0; i < 4; i++)
        {
            combatants[i].attack(combatants);
        }
        Console.WriteLine(enemy);
        Console.WriteLine(fighter);
        Console.WriteLine(knight);
        Console.WriteLine(sorcerer);
        numberOfAlive = countAlive();
        Console.WriteLine(numberOfAlive);
        
    }
    for (int i = 0; i < 4; i++)
    {
        if (!combatants[i].IsAlive == false)
        {
            combatants[i].wins += 1;
        }
    }
    for (int i = 0;i < 4; i++)
    {
        combatants[i].HP = combatants[i].MaxHP;
        combatants[i].IsAlive = true;
    }
    sorcerer.mana = sorcerer.maxMana;
    Console.WriteLine("wins");
    for (int i = 0; i < 4; i++)
    {
        if (combatants[i].wins > 0)
        {
            Console.WriteLine(combatants[i].wins);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
    Console.WriteLine("is alive");
    for (int i =0; i < 4; i++)
    {
        Console.WriteLine(combatants[i].IsAlive);
    }
    numberOfAlive = 4;
    Console.WriteLine("numberOfAlive");
    Console.WriteLine(numberOfAlive);
}
double wins = 0;
for (int i = 0; i < 4; i++)
{
    if (combatants[i].wins > 0)
    {
        wins = combatants[i].wins;
        wins = Math.Round(wins, 2);
        Console.Write(wins / numberOfBattles * 100);
        Console.WriteLine("%");
    }
    else
    {
        Console.WriteLine(0);
    }
}
int countAlive()
{
    int count = 0;
    for (int i = 0;i < 4; i++)
    {
        if (combatants[i].IsAlive)
        {
            count++;
        }
    }
    return count;
}