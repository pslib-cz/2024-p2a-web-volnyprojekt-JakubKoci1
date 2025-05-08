using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale
{
    internal class Sorcerer : Combatants
    {
        public Sorcerer(int hP, int maxHP, bool isAlive, string name, int mana, int manaDrain, int damage, int ManaDamgage, int Wins, int maxMana)
        {
            HP = hP;
            MaxHP = maxHP;
            IsAlive = isAlive;
            Name = name;
            this.mana = mana;
            this.manaDrain = manaDrain;
            this.damage = damage;
            this.manaDamgage = ManaDamgage;
            this.wins = Wins;
            this.maxMana = maxMana;
        }

        public int HP { get; set; }
        public int MaxHP { get; set; }
        public bool IsAlive { get; set; }
        public string Name { get; set; }
        public int mana {  get; set; }
        public int maxMana {  get; set; }
        public int manaDrain { get; set; }
        public int damage { get; set; }
        public int manaDamgage { get; set; }
        public int wins { get; set; }
        public void RecieveDamage(int damage)
        {
            this.HP -= damage;
            if (this.HP <= 0)
            {
                this.IsAlive = false;

                this.HP = 0;
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
            if (this.mana > this.manaDrain)
            {
                if (this.IsAlive = false)
                {
                    values[pickOpponent(values)].RecieveDamage(this.manaDamgage);
                }
            }
            else
            {
                if (this.IsAlive)
                {
                    values[pickOpponent(values)].RecieveDamage(this.damage);
                }
            }
        }
        public override string ToString()
        {
            Console.WriteLine(this.Name + " HP: " + this.HP + "/" + this.MaxHP);
            return base.ToString();
        }
    }
}
