using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_poker
{
    internal class Game
    {
        public Game(int playerNumber, int round, int player1score, int player2score, bool isended, int maxRound, string player1scorename, string player2scorename)
        {
            this.playerNumber = playerNumber;
            this.round = round;
            this.player1score = player1score;
            this.player2score = player2score;
            this.isEnded = isended;
            this.maxround = maxRound;
            this.player1scorename = player1scorename;
            this.player2scorename = player2scorename;
        }

        public int playerNumber {  get; set; }
        public int round {  get; set; }
        public int player1score { get; set; }
        public int player2score { get; set; }
        public string player1scorename { get; set; }
        public string player2scorename { get; set; }
        public bool isEnded { get; set; }
        public int maxround { get; set; }
        public void endscreen()
        {
            Console.WriteLine("Player 1: " + player1score + " : " + player1scorename);
            Console.WriteLine("Player 2: " + player2score + " : " + player2scorename);
            Console.WriteLine("");
            if (player1score > player2score)
            {
                Console.WriteLine("player 1 wins");
            }
            else if (player1score < player2score)
            {
                Console.WriteLine("player 2 wins");
            }
            else
            {
                Console.WriteLine("draw");
            }
            Console.WriteLine("");
        }
    }
}
