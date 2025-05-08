// See https://aka.ms/new-console-template for more information
using Dice_poker;

Dice dice1 = new Dice(6, 0, false);
Dice dice2 = new Dice(6, 0, false);
Dice dice3 = new Dice(6, 0, false);
Dice dice4 = new Dice(6, 0, false);
Dice dice5 = new Dice(6, 0, false);
Dice dice6 = new Dice(6, 0, false);
Dice dice7 = new Dice(6, 0, false);
Dice dice8 = new Dice(6, 0, false);
Dice dice9 = new Dice(6, 0, false);
Dice dice10 = new Dice(6, 0, false);
List<Dice> Player1dices = new List<Dice>();
List<Dice> Player2dices = new List<Dice>();
Player1dices.Add(dice1);
Player1dices.Add(dice2);
Player1dices.Add(dice3);
Player1dices.Add(dice4);
Player1dices.Add(dice5);
Player2dices.Add(dice6);
Player2dices.Add(dice7);
Player2dices.Add(dice8);
Player2dices.Add(dice9);
Player2dices.Add(dice10);
Round round = new Round(0, "unknown");
Console.WriteLine("write anything to start the game");
Game game = new Game(1, 1, 0, 0, false, 2, "unknown", "unknown");
string? input = Console.ReadLine();
Console.Clear();
Console.WriteLine("write the number of rounds (if you do not input a positive non zero number then the number of rounds will be 2)");
input = Console.ReadLine();
if (input == "" || !IsDigitsOnly(input) || input == "0")
{
    game.maxround = 2;
}
else if (IsDigitsOnly(input))
{
    game.maxround = Convert.ToInt32(input);
}

Console.Clear();
round.rollDices(Player1dices);
round.rollDices(Player2dices);
round.value(Player1dices);

while (true)
{
    if (game.isEnded == false)
    {

        if (game.playerNumber == 1)
        {
            round.state(Player1dices, 1);
        }
        else
        {
            round.state(Player2dices, 2);
        }
        Console.WriteLine("exit: exits game, lock: lock a dice, roll: rolls all unlocked dices");
        input = Console.ReadLine();

        if (input == "exit") { break; }
        else if (input == "lock")
        {
            Console.WriteLine("select the dice to lock by writing a number from 1 to 5");
            input = Console.ReadLine();
            if (input == "cancel")
            {

            }
            else if (input == "" || !IsDigitsOnly(input))
            {
                
            }
            else if (Convert.ToInt32(input) < 6 && Convert.ToInt32(input) > 0)
            {
                if (game.playerNumber == 1)
                {

                    round.lockDice(Player1dices, Convert.ToInt32(input) - 1);
                }
                else
                {
                    round.lockDice(Player2dices, Convert.ToInt32(input) - 1);
                }
            }

        }
        else if (input == "roll")
        {
            if (game.playerNumber == 1)
            {
                round.rollDices(Player1dices);
                round.value(Player2dices);
                game.playerNumber = 2;
            }
            else if (game.playerNumber == 2)
            {
                if (game.round < game.maxround)
                {
                    round.rollDices(Player2dices);
                    round.value(Player1dices);
                    game.playerNumber = 1;
                    game.round ++;
                }
                else
                {
                    round.rollDices(Player2dices);
                    round.value(Player2dices);
                    game.playerNumber = 2;
                    game.isEnded = true;
                }
            }
        }
        Console.Clear();
    }
    else
    {
        round.value(Player1dices);
        game.player1score = round.score;
        game.player1scorename = round.scoreName;
        round.value(Player2dices);
        game.player2score = round.score;
        game.player2scorename = round.scoreName;
        game.endscreen();
        Console.WriteLine("exit: exits the game, reset: restarts the game");
        input = Console.ReadLine();
        if (input == "exit")
        {
            break;
        }
        else if (input == "reset")
        {
            dice1.value = 0;
            dice2.value = 0;
            dice3.value = 0;
            dice4.value = 0;
            dice5.value = 0;
            dice6.value = 0;
            dice7.value = 0;
            dice8.value = 0;
            dice9.value = 0;
            dice10.value = 0;
            dice1.locked = false;
            dice2.locked = false;
            dice3.locked = false;
            dice4.locked = false;
            dice5.locked = false;
            dice6.locked = false;
            dice7.locked = false;
            dice8.locked = false;
            dice9.locked = false;
            dice10.locked = false;
            game.playerNumber = 1;
            game.round = 1;
            round.rollDices(Player1dices);
            round.rollDices(Player2dices);
            round.value(Player1dices);
            game.isEnded = false;
            Console.Clear();
            Console.WriteLine("write the number of rounds (if you do not input a positive non zero number then the number of rounds will be 2)");
            input = Console.ReadLine();
            if (input == "" || !IsDigitsOnly(input) || input == "0")
            {
                game.maxround = 2;
            }
            else if (IsDigitsOnly(input))
            {
                game.maxround = Convert.ToInt32(input);
            }
            
            Console.Clear();
        }
    }
}



bool IsDigitsOnly(string str)
{
    foreach (char c in str)
    {
        if (c < '0' || c > '9')
            return false;
    }

    return true;
}