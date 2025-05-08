using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale
{
    public interface Combatants
    {
        

        public bool IsAlive { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int damage { get; set; }
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
            while (values[rInt].IsAlive == false)
            {
                Random R = new Random();
                int RInt = R.Next(0, 4);
            }
            return rInt;
        }

        public void attack(List<Combatants> values)
        {
            if (this.IsAlive)
            {
                values[pickOpponent(values)].RecieveDamage(this.damage);
            }
        }
    }
}
