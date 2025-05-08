using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_poker
{
    internal class Dice
    {
        public Dice(int sides, int value, bool locked)
        {
            this.sides = sides;
            this.value = value;
            this.locked = locked;
        }

        public int sides {  get; set; }
        public int value { get; set; }
        public bool locked { get; set; }
        public void roll ()
        {
            if (!this.locked)
            {
                Random r = new Random();
                int rInt = r.Next(1, 7);
                this.value = rInt;
            }
        }
    }
}
