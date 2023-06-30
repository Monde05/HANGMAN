using System;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain;
            do
            {
                Console.Clear(); 

                string word = "repository";
                string hint = "hint: GITHUB";
                int lives = 8;
                char[] guessedLetters = new char[word.Length];
                bool wordGuessed = false;

                Console.WriteLine("HEY BESTIE, WELCOME TO HANGMAN!!");
                Console.WriteLine("The game is quite simple, Just guess the letters of the secret word");
                Console.WriteLine("Remember: You have only 8 lives");
                Console.WriteLine(hint);

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("lives remaining: " + lives);
                    Console.WriteLine("Guessed letters: " + string.Join(" ", guessedLetters));
                    Console.Write("Pick a letter: ");
                    char guessedLetter = Console.ReadLine()[0];

                    bool letterGuessedCorrectly = false;

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == guessedLetter)
                        {
                            guessedLetters[i] = guessedLetter;
                            letterGuessedCorrectly = true;
                        }
                    }

                    if (!letterGuessedCorrectly)
                    {
                        lives--;
                        Console.WriteLine("AOWA MY SISTA! try again!");
                    }

                    if (new string(guessedLetters) == word)
                    {
                        wordGuessed = true;
                    }

                } while (!wordGuessed && lives > 0);

                Console.WriteLine();

                if (wordGuessed)
                {
                    Console.WriteLine("YAAAAAAAAASSSSSS! You got it: " + word);
                }
                else
                {
                    Console.WriteLine("Aww Better luck next time! The word was: " +word);
                }

                Console.Write("Play again? (Y/N): ");
                char playAgainChoice = char.ToLower(Console.ReadLine()[0]);
                playAgain = (playAgainChoice == 'y');

            } while (playAgain);

            Console.WriteLine("Thank you for playing Hangman, Till next time");
            Console.ReadKey();

        }

    }
}
