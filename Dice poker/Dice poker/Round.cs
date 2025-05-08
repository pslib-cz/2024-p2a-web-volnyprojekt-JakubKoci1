using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Dice_poker
{
    internal class Round
    {
        public Round(int score, string scoreName)
        {
            this.score = score;
            this.scoreName = scoreName;
        }

        public int score {  get; set; }
        public string scoreName { get; set; }
        public void rollDices(List<Dice> dices)
        {
            for (int i = 0; i < 5; i++)
            {
                if (!dices[i].locked)
                {
                    dices[i].roll();
                }
            }
        }
        public void lockDice (List<Dice> dices, int number)
        {
            if (dices[number].locked)
            {
                dices[number].locked = false;
            }
            else
            {
                dices[number].locked = true;
            }
        }
        
        public void state(List<Dice> dices, int playernumber)
        {
            Console.WriteLine("Player " + playernumber + " turn");
            for (int j = 0; j < 5; j++)
            {
                int i = j + 1;
                string locked;
                if (dices[j].locked)
                {
                    locked = "Locked";
                }
                else
                {
                    locked = "Unlocked";
                }
                Console.WriteLine("Dice " + i + ": " + dices[j].value + ", " + locked);
            }
            Console.WriteLine("");
            Console.WriteLine(this.scoreName);
            Console.WriteLine(this.score);
            Console.WriteLine("");
        }
        public void value(List<Dice> dices)
        {
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int numberof = 0;
            int numberof1 = 0;
            int numberof2 = 0;
            int numberof3 = 0;
            int numberof4 = 0;
            int numberof5 = 0;
            int numberof6 = 0;
            for (int i = 0;i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (dices[j].value == i + 1)
                    {
                        numberof++;
                    }
                    
                    
                }
                if (numberof == 5)
                {
                    count5++;
                }
                else if (numberof == 4)
                {
                    count4++;
                }
                else if (numberof == 3)
                {
                    count3++;
                }
                else if (numberof == 2)
                {
                    count2++;
                }
                else if (numberof == 1)
                {
                    count1++;
                }
                numberof = 0;
            }
            for (int i = 0; i < 5; i++)
            {
                if (dices[i].value == 1)
                {
                    numberof1++;
                }
                else if (dices[i].value == 2)
                {
                    numberof2++;
                }
                else if (dices[i].value == 3)
                {
                    numberof3++;
                }
                else if (dices[i].value == 4)
                {
                    numberof4++;
                }
                else if (dices[i].value == 5)
                {
                    numberof5++;
                }
                else if (dices[i].value == 6)
                {
                    numberof6++;
                }

            }
            if (count5 == 1)
            {
                this.score = 9;
                this.scoreName = "five of a kind";
            }
            else if (count4 == 1)
            {
                this.score = 8;
                this.scoreName = "four of a kind";
            }
            else if (count3 == 1 && count2 == 1)
            {
                this.score = 7;
                this.scoreName = "full house";
            }
            
            else if ( numberof5 == 1 && numberof4 == 1 && numberof3 == 1 && numberof2 == 1)
            {
                if (numberof6 == 1)
                {
                    this.score = 6;
                    this.scoreName = "six high straight";
                }
                else if (numberof1 == 1) 
                {
                    this.score = 5;
                    this.scoreName = "five high straight";
                    
                }
            }
            else if (count3 == 1)
            {
                this.score = 4;
                this.scoreName = "three of a kind";
                
            }
            else if (count2 == 2)
            {
                this.score = 3;
                this.scoreName = "two pairs";
                
            }
            else if (count2 == 1)
            {
                this.score = 2;
                
                this.scoreName = "pair";
                
            }
            else
            {
                this.score = 1;
                
                this.scoreName = "nothing";
                
            }
        }
    }
}
