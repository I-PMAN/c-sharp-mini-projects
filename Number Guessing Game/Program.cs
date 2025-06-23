using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random rand = new Random();

            int randomNumber = rand.Next(1, 11);
            Console.WriteLine("Welcome to Guess the number!");
            Console.WriteLine("A number beetween 1 and 10 will be generated.");
            Console.WriteLine("If you guess the correct number, you win!");

            while(!isCorrectGuess)
            {
                Console.WriteLine("Enter a number.");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNumber)
                {
                    Console.WriteLine("Guess lower.");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Guess higher.");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    isCorrectGuess = true;
                }

            }
            Console.WriteLine("Hooray!! You have won the game.");
        }

    }
}
