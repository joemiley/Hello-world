using System;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Collections.Generic;

namespace z.hangman1
{
    class Program
    {
        public static int outCome = 0;
        public static int wrongCounter = 7;
        // random to use 
        public static Random rng = new Random();
        public static string replay = "";
        // changing the secret word to a tape
        public static string secretWord;
        public static StringBuilder secretWordTape;
        //for the hashed output
        public static StringBuilder globalHashTape;
        // this is where the extension to the dictionary.txt
        public static string[] lines = File.ReadAllLines(@"C:\Users\Rando\Desktop\coding\Hello-world\c#\dictionary.txt");
        public static List<string> potentialWords = new List<string>();
        public static List<char> wrongGuessedLettersList = new List<char>();
        public static List<char> rightGuessedLettersList = new List<char>();
        public static List<int> rightGuessedLettersListPositions = new List<int>();
        public static bool statisticsVeiw = false;


        static void Main(string[] args)
        {
            //loops through the system unless the user does not wish to play again
            //hoovering over the below methods a short description will appear instructing on what their function is 
            do
            {
                InitiallyPickingAWordAndMenu();

                Game();

                Console.WriteLine("Would you like to play again? y/n");
                replay = Console.ReadLine().ToLower();

                GameReset();

            } while (replay == "y");

            Console.WriteLine("Have a nice day");
            Console.ReadLine();
        }

        /// <summary>
        /// main menu system, picking words and statistics on/off
        /// </summary>
        public static void InitiallyPickingAWordAndMenu()
        {
            int choicenum;
            do
            {
                int letterAmount;
                string statistics = "";

                do
                {
                    Console.Clear();

                    Console.WriteLine("Welcome to Guessing The Word");
                    Console.WriteLine();
                    Console.WriteLine("would you like statistics on? y/n");
                    statistics = Console.ReadLine().ToLower();

                } while (statistics != "y" && statistics != "n");

                if (statistics == "y")
                {
                    statisticsVeiw = true;
                }

                Console.WriteLine();
                Console.WriteLine("Please choose from the following options:");
                Console.WriteLine("1. i would like to choose the length of the word and wrong counter manually.");
                Console.WriteLine("2. i would like the length of the word would be randomly allocated and the wrong counter to be 7.");
                Console.WriteLine("please enter the number of option you would like to choose");
                string choice = Console.ReadLine();

                Int32.TryParse(choice, out choicenum);

                if (choicenum == 1)
                {
                    do
                    {
                        Console.WriteLine("please enter a letter amount: ");
                        string stringletterAmount = Console.ReadLine();
                        Int32.TryParse(stringletterAmount, out letterAmount);

                    } while (letterAmount <= 0 || letterAmount == 1 || letterAmount == 23 || letterAmount == 25 || letterAmount == 26 || letterAmount == 27 || letterAmount == 30);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Length == letterAmount)
                        {
                            potentialWords.Add(lines[i]);
                        }
                    }

                    do
                    {
                        Console.WriteLine("how many wrong guesses should be allowed to the player?");
                        string stringwrongCounter = Console.ReadLine();
                        Int32.TryParse(stringwrongCounter, out wrongCounter);
                    } while (wrongCounter <= 0);
                }

                if (choicenum == 2)
                {
                    do
                    {
                        letterAmount = rng.Next(1, 31);

                    } while (letterAmount == 1 || letterAmount == 23 || letterAmount == 25 || letterAmount == 26 || letterAmount == 27 || letterAmount == 30);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Length == letterAmount)
                        {
                            potentialWords.Add(lines[i]);
                        }
                    }
                }
            } while (choicenum <= 0 || choicenum > 2 );

            secretWord = potentialWords[rng.Next(0, potentialWords.Count)];
        }

        /// <summary>
        /// main gameplay loop with win and loose screens
        /// </summary>
        public static void Game()
        {
            // main gameplay loop works off the outcome variable for winning screens and calls the other modules
            do
            {
                Console.Clear();
                Console.WriteLine("incorrectCounter: " + wrongGuessedLettersList.Count.ToString());

                //cuts potential word list with every guess using 4 rules
                AI();

                //randomizes through the potential words left after Ai has done its job
                RandomSecretWord();

                //outputs secretword information to the user using the globalHastTape variable 
                HashTape();

                /*
                 * if globalHashTape is the same as the secret word after all the functions for that round has been done on it
                 * then this shows the user the win screen
                 * or if the wrong counter gets too high then it shows the loose screen
                 */
                if (secretWord == globalHashTape.ToString())
                {
                    outCome = 1;
                }
                else if(wrongGuessedLettersList.Count > wrongCounter)
                {
                    outCome = 2;
                }

                else
                {
                    // space between the underscores and the guess
                    Console.WriteLine();
                    Console.WriteLine();

                    // guess from the user
                    Console.WriteLine("input your guess");
                    string guess = Console.ReadLine().ToLower();

                    // changing the guess to a tape
                    StringBuilder guessTape = new StringBuilder(guess);

                    // word guesses
                    if (guessTape.Length > 1)
                    {
                        GuessingWholeWords(guess);
                    }

                    // letter guesses
                    // right
                    if (guessTape.Length == 1 && secretWord.Contains(guessTape[0]) == true)
                    {
                        RightGuessedLetter(guessTape);
                    }
                    // wrong
                    else if (guessTape.Length == 1 && secretWord.Contains(guessTape[0]) == false)
                    {
                        WrongGuessedLetter(guessTape);
                    }
                }
                
                // loops it
            } while (outCome == 0);

            // win screen
            if (outCome == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Congradulations you win!");
                Console.WriteLine();

            }

            // loose screen
            else
            {
                Console.WriteLine();
                Console.WriteLine("so sad but you've lost");
                Console.WriteLine("the word was " + secretWord);
            }

        }

        /// <summary>
        /// mainly removes words and prints statistics
        /// </summary>
        public static void AI()
        {
            //outputs
            Console.Write("rightGuessedLettersList: ");
            for (int i = 0; i < rightGuessedLettersList.Count; i++)
            {
                Console.Write(rightGuessedLettersList[i] + " ");
            }
            Console.WriteLine();
            Console.Write("wrongGuessedLettersList: ");
            for (int i = 0; i < wrongGuessedLettersList.Count; i++)
            {
                Console.Write(wrongGuessedLettersList[i] + " ");
            }
            Console.WriteLine();
            Console.Write("rightGuessedLettersListPositions: ");
            for (int i = 0; i < rightGuessedLettersListPositions.Count; i++)
            {
                Console.Write(rightGuessedLettersListPositions[i] + " ");
            }
            Console.WriteLine();

            // if a word doesn't contain correct letter list
            for(int i = 0; i < potentialWords.Count; i++)
            {
                for(int j = 0; j < rightGuessedLettersList.Count; j++)
                {
                    if (potentialWords[i].Contains(rightGuessedLettersList[j]) == false)
                    {
                        potentialWords.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }

            // is the letter in the correct posistion
            for (int i = 0;i <potentialWords.Count; i++)
            {
                StringBuilder currentWord = new StringBuilder(potentialWords[i]);

                for (int j = 0; j < rightGuessedLettersListPositions.Count; j++)
                {
                    if (currentWord[rightGuessedLettersListPositions[j]] != rightGuessedLettersList[j])
                    {

                        potentialWords.RemoveAt(i);
                        i--;
                        break;
                    }

                }
            }

            // if the word has a wrong guessed letter in it
            for(int i = 0; i < potentialWords.Count; i++)
            {
                for(int j = 0; j < wrongGuessedLettersList.Count; j++)
                {
                    if(potentialWords[i].Contains(wrongGuessedLettersList[j])== true)
                    {
                        potentialWords.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }

            for(int i = 0; i<potentialWords.Count; i++)
            { 
                StringBuilder currentWord = new StringBuilder(potentialWords[i]);
                for(int j = 0; j < currentWord.Length; j++)
                {
                    for(int k = 0; k < rightGuessedLettersList.Count; k++)
                    {
                        if(currentWord[j] == rightGuessedLettersList[k])
                        {
                            if(rightGuessedLettersListPositions.Contains(j)== false)
                            {
                                
                                if (i != 0) 
                                {
                                    potentialWords.RemoveAt(i);
                                    i--;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            if(statisticsVeiw == true)
            {
                Console.WriteLine("potential words remaining :" + potentialWords.Count);
                Console.WriteLine();
            }

        }

        /// <summary>
        /// randomizes through the potentialWords list and picks the word the user is trying to guess
        /// </summary>
        public static void RandomSecretWord()
        {
            if(potentialWords.Count > 1)
            {
                secretWord = potentialWords[rng.Next(0, potentialWords.Count)];
            }

            if(statisticsVeiw == true)
            {
                Console.WriteLine("secret word: " + secretWord);
            }

            globalHashTape = new StringBuilder(secretWord);
            secretWordTape = new StringBuilder(secretWord);

            if(statisticsVeiw == true)
            {
                Console.Write("secretwordtape: ");
                for (int i = 0; i < secretWordTape.Length; i++)
                {
                    Console.Write(secretWordTape[i] + " ");
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// updates the globalHashTape to show the user what they have right
        /// </summary>
        public static void HashTape()
        {
            //this is built off the global hashtape
            Console.Write("secret word: ");
            for (int i = 0; i < globalHashTape.Length; i++)
            {
                globalHashTape[i] = "_"[0];
            }

            for (int i = 0; i < rightGuessedLettersListPositions.Count; i++)
            {
                if (secretWordTape[rightGuessedLettersListPositions[i]] == rightGuessedLettersList[i])
                {
                    globalHashTape[rightGuessedLettersListPositions[i]] = rightGuessedLettersList[i];
                }
            }

            for (int i = 0; i < globalHashTape.Length; i++)
            {
                Console.Write(globalHashTape[i] + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// deals with when the user guesses the whole word correctly. if not then it adds a . to the wrong guessed letters list
        /// </summary>
        /// <param name="guess"></param>
        public static void GuessingWholeWords(string guess)
        {
            // if they guess the word wholely right
            if (guess == secretWord)
            {
                outCome = 1;
            }

            //if the guess is wrong
            if (guess != secretWord)
            {
                wrongGuessedLettersList.Add("."[0]);
            }
        }

        /// <summary>
        /// if the user guesses right then it is added to the right guessed leter list for the Ai module to use in cutting down words
        /// note: right guessed letters and their posistions are saved at the same posistions in both lists so one loop can be used
        /// </summary>
        /// <param name="guessTape"></param>
        public static void RightGuessedLetter(StringBuilder guessTape)
        {
            if (rightGuessedLettersList.Contains(guessTape[0]))
            {
                return;
            }

            for (int i = 0; i < secretWordTape.Length; i++)
            {
                if(secretWordTape[i] == guessTape[0])
                {

                    rightGuessedLettersList.Add(guessTape[0]);
                    rightGuessedLettersListPositions.Add(i);

                }
            }
        }

        /// <summary>
        /// add the wrong guessed letters to the list so the Ai module can use them
        /// </summary>
        /// <param name="guessTape"></param>
        public static void WrongGuessedLetter(StringBuilder guessTape)
        {
            if(wrongGuessedLettersList.Contains(guessTape[0]) == true)
            {
                return;
            }
            else
            {
                wrongGuessedLettersList.Add(guessTape[0]);
            }
        }

        /// <summary>
        /// reset all game variables
        /// </summary>
        public static void GameReset()
        {
            rightGuessedLettersList.Clear();
            rightGuessedLettersListPositions.Clear();
            wrongGuessedLettersList.Clear();
            statisticsVeiw = false;
            outCome = 0;
        }
    }
}



