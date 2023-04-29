using System;

namespace GuessThePokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Game class
            Game game = new Game();
            
            // Display welcome message
            game.DisplayWelcomeMessage();
            
            // Main game loop
            while (!game.GameOver)
            {
                // Display current game state
                game.DisplayGameState();
                
                // Get user input for letter guess
                char letterGuess = game.GetUserInput();
                
                // Check if letter is present in the hidden Pokémon name
                bool isCorrectGuess = game.CheckLetterGuess(letterGuess);
                
                // Update game state based on guess
                game.UpdateGameState(isCorrectGuess);
            }
            
            // Display end game message
            game.DisplayEndGameMessage();
        }
    }
}
