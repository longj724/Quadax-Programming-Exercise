using System;
using System.Text;

namespace MastermindQuadax
{
    class MainClass
    {
        public static void Mastermind()
        {
            StringBuilder randomNumber = new StringBuilder();
            Random randGenerator = new Random();

            // Generating the randomNumber
            for (int i = 0; i < 4; ++i)
            {
                randomNumber.Append(randGenerator.Next(1, 7));
            }

            // StringBuilder for outputing the player's current guess
            StringBuilder recentGuess = new StringBuilder("    ");

            Console.WriteLine("Welcome to Mastermind");

            // Loop that runs each each round
            for (int i = 0; i < 10; ++i)
            {
                // Retrieve the player's guess and convert it to a string
                Console.WriteLine("Enter your guess:");
                int playerGuess;

                playerGuess = Convert.ToInt32(Console.ReadLine());

                string formattedGuess = playerGuess.ToString();

                // Compare Guess to the random number
                for (int j = 0; j < 4; ++j)
                {
                    // If the digit is in the correct position
                    if (randomNumber[j].Equals(formattedGuess[j]))
                    {
                        recentGuess[j] = '+';

                    // If the digit is in the random number but wrong position
                    }
                    else if (randomNumber.ToString().Contains(formattedGuess[j].ToString()))
                    {
                        recentGuess[j] = '-';
                    }
                }

                // Determine if guess info should be outputed to the player
                if (recentGuess.ToString() != "    ")
                {
                    Console.WriteLine(recentGuess);
                }

                // If the player correctly guessed the number
                if (recentGuess.ToString() == "++++")
                {
                    Console.WriteLine("Congratulations You Won!");
                    return;
                }

                // Reset recentGuess
                recentGuess.Replace('-', ' ');
                recentGuess.Replace('+', ' ');
            }
            // If the player lost
            Console.WriteLine("Sorry, You have lost the game.");
        }

        public static void Main(string[] args)
        {
            // Play Mastermind
            Mastermind();
        }
    }
}
