using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            int playerRandomNum;
            int botRandomNum;
            int playerPoints = 0;
            int botPoints = 0;

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                botRandomNum = random.Next(1, 7);
                Console.WriteLine("Bot rolled a " + botRandomNum);

                if (playerRandomNum > botRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");
                }
                else if (playerRandomNum < botRandomNum)
                {
                    botPoints++;
                    Console.WriteLine("Bot wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("The score is now - Player : " + playerPoints + ". Bot : " + botPoints + ".");
                Console.WriteLine();
            }

            if (playerPoints > botPoints)
            {
                Console.WriteLine("You win!");
            }
            else if (playerPoints < botPoints)
            {
                Console.WriteLine("Bot wins!");
            }
            else
            {
                Console.WriteLine("It is a draw!");
            }
        }
    }
}
