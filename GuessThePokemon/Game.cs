using System;

namespace GuessThePokemon
{
    class Game
    {
        private string[] pokemons = new string[20]
        {
            "pikachu", "charizard", "bulbasaur", "jigglypuff", "meowth",
            "psyduck", "mankey", "growlithe", "poliwag", "abra",
            "machop", "bellsprout", "tentacool", "geodude", "ponyta",
            "slowpoke", "magnemite", "seel", "ditto", "eevee"
        };
        private string hiddenPokemon;
        private string[] revealedPokemon;
        private int remainingGuesses;
        private bool[] guessedLetters;
        private bool gameWon;
        private bool gameLost;

        public bool GameOver { get { return gameWon || gameLost; } }

        public Game()
        {
            // Initialize game state
            hiddenPokemon = SelectRandomPokemon();
            revealedPokemon = new string[hiddenPokemon.Length];
            for (int i = 0; i < hiddenPokemon.Length; i++)
            {
                revealedPokemon[i] = "_";
            }
            remainingGuesses = 10;
            guessedLetters = new bool[26];
            gameWon = false;
            gameLost = false;
        }

        // To Display welcome message and Instructions!
        public void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome To The Game of Guess the pokémon!");
            Console.WriteLine("Guess the Initial Letter to Initialize");
            Console.WriteLine("To reveal the hidden pokémon,Please enter blank spaces with letters");
            Console.WriteLine("You have 10 guesses to correctly guess the Pokémon name.");
            Console.WriteLine("IMP Note: Please do not repeat any letter on another attempt.");
            Console.WriteLine("Good luck And Have Fun!:)");
            Console.WriteLine();
        }

        // Display current game state
        public void DisplayGameState()
        {
            Console.WriteLine("Remaining guesses: " + remainingGuesses);
            Console.WriteLine("Pokémon name: " + string.Join(" ", revealedPokemon));
            Console.WriteLine();
        }

        // Get user input for letter guess
        public char GetUserInput()
        {
            char letterGuess;
            bool validInput = false;
            do
            {
                Console.Write("Enter a letter guess: ");
                string input = Console.ReadLine();
                validInput = char.TryParse(input, out letterGuess);
                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a letter.");
                }
            } while (!validInput);
            return letterGuess;
        }

        // Check if letter is present in the hidden Pokémon name
        public bool CheckLetterGuess(char letterGuess)
        {
            bool isCorrectGuess = false;
            for (int i = 0; i < hiddenPokemon.Length; i++)
            {
                if (hiddenPokemon[i] == letterGuess)
                {
                    isCorrectGuess = true;
                    revealedPokemon[i] = letterGuess.ToString();
                }
            }
            return isCorrectGuess;
        }

        // Update game state based on guess
        public void UpdateGameState(bool isCorrectGuess)
        {
            if (isCorrectGuess)
            {
                Console.WriteLine("Correct guess!");
            }
            else
            {
                Console.WriteLine("Incorrect guess.");
                remainingGuesses--;
            }

            // Check for win
            if (string.Join("", revealedPokemon) == hiddenPokemon)
            {
                gameWon = true;
            }

            // Check for loss
            if (remainingGuesses == 0)
            {
                gameLost = true;
            }

            Console.WriteLine();
        }

        // Display end of the game message at the end of game
        public void DisplayEndGameMessage()
        {
            Console.WriteLine("Game over!");

            if (gameWon)
            {
                Console.WriteLine("Congratulations! You correctly guessed the Pokémon: " + hiddenPokemon);
            }
            else if (gameLost)
            {
                Console.WriteLine("Oops! You ran out of guesses. The Pokémon was: " + hiddenPokemon);
            }

            Console.WriteLine("Thanks for playing Guess the Pokémon!");
        }

        // Select a random Pokémon name from the list
        private string SelectRandomPokemon()
        {
            Random random = new Random();
            int index = random.Next(0, pokemons.Length);
            return pokemons[index];
        }
    }
}