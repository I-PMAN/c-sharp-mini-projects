using System;

namespace TurnBased
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int botHp = 20;

            int playerAttack = 5;
            int botAttack = 7;

            int healAmount = 5;
            
            Random random = new Random();

            while(playerHp > 0 && botHp > 0)
            {
                Console.WriteLine("--Player turn--");
                Console.WriteLine("Player Hp - " + playerHp + ". Bot Hp - " + botHp);
                Console.WriteLine("Enter 'a' to  attack or 'h' to heal.");

                string choice = Console.ReadLine();

                if(choice == "a")
                {
                    botHp -= playerAttack;
                    Console.WriteLine("Player attacks bot and deals " + playerAttack + " damage!");
                }
                else
                {
                    playerHp += healAmount;
                    Console.WriteLine("Player restores " + healAmount + " health points!");
                }

                //Bot turn
                if (botHp > 0)
                {
                    Console.WriteLine("-- Bot turn --");
                    Console.WriteLine("Player Hp - " + playerHp + ". Bot Hp - " + botHp);
                    int botChoice = random.Next(0, 2);

                    if (botChoice == 0)
                    {
                        playerHp -= botAttack;
                        Console.WriteLine("Bot attacks and deals " + botAttack + " damage!");
                    }
                    else
                    {
                        botHp += healAmount;
                        Console.WriteLine("Bot restores " + healAmount + " health points!");
                    }
                }
            }
            if (playerHp > 0)
            {
                Console.WriteLine("Congratulations, you have won!");
            }
            else
            {
                Console.WriteLine("You loose!");
            }
        }
    }
}