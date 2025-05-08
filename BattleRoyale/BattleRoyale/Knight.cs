using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale
{
    public class Knight : Combatants
    {
        public Knight(int hP, int maxHP, bool isAlive, string name, int armor, int damage, int Wins)
        {
            HP = hP;
            MaxHP = maxHP;
            IsAlive = isAlive;
            Name = name;
            Armor = armor;
            this.damage = damage;
            this.wins = Wins;
        }

        public int HP { get; set; }
        public int MaxHP { get; set; }
        public bool IsAlive { get; set; }
        public string Name { get; set; }
        public int Armor {  get; set; }
        public int damage { get; set; }
        public int wins { get ; set; }
        public void RecieveDamage(int damage)
        {
            if (damage - Armor <= 0)
            {
                damage = 0;
            }
            else
            {
                damage -= Armor;
            }
            if (this.HP - damage <= 0)
            {
                this.HP = 0;
                IsAlive = false;
            }
            else
            {
                this.HP -= damage;
            }
        }
        public int pickOpponent(List<Combatants> values)
        {
            Random r = new Random();
            int rInt = r.Next(0, 4);
            
            return rInt;
        }

        public void attack(List<Combatants> values)
        {
            if (this.IsAlive)
            {
                values[pickOpponent(values)].RecieveDamage(this.damage);
            }
        }
        public override string ToString()
        {
            Console.WriteLine(this.Name + " HP: " + this.HP + "/" + this.MaxHP);
            return base.ToString();
        }
    }
}
