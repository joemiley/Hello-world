using System;

namespace IntroToProg_20189_Sem12_Week9_Methods
{
    class MainClass
    {
        // global variables - accessible throughout all methods
        // NOTE: Visual Studio will suggest you remove the bits between = and {
        // That can be done, as the contents between the {} is used to
        // infer the "new int[3]" part
        public static int[] leaderBoard = new int[3] { 0, 0, 0 };

        /** d6 dice structure:
         *  position => value
         *  0,0 => 1
         *  1,0 => 2
         *  2,0 => 3
         *  3,0 => 4
         *  4,0 => 5
         *  5,0 => 6
         */
        // NOTE: Visual Studio will suggest you remove the bits between = and {
        // That can be done, as the contents between the {} is used to
        // infer the "new int[6, 1]" part
        public static int[,] d6 = new int[6, 1] {
            { 1 },
            { 2 },
            { 3 },
            { 4 },
            { 5 },
            { 6 }
        };

        // random number generator, used to generate dice rolls
        public static Random rng = new Random();

        /**
         * {
         *  { SCORE_ROUND1, SCORE_ROUND2, ... }, // ROW => PLAYER 1
         *  { SCORE_ROUND1, SCORE_ROUND2, ... }, // PLAYER 2
         *  ...
         * }
         */
        public static int[,] playerRoundsScores;

        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        public static void Main()
        {
            /**
             * 3x3 Matrix
             * 
             * 1 2 3
             * 4 5 6
             * 7 8 9
             * 
             * value 1 => position 0,0
             * value 9 => position 2,2
             * ...
             * 
             */

            // variables

            // store the user menu choice
            char userChoice;
            // store the current game score
            int score;

            // looping structure
            do
            {

                // empty the window contents 
                // NOTE: Technically, it just inserts lots of empty lines really quickly
                // Feel free to scroll up ...
                Console.Clear();

                // menu
                ShowMenu();

                // prompt for user choice
                userChoice = GetUserChoice("Please choose one: ");

                // empty the window contents 
                // NOTE: Technically, it just inserts lots of empty lines really quickly
                // Feel free to scroll up ...
                Console.Clear();

                // check user choice
                switch (userChoice)
                {
                    // start new game
                    case 'n':

                        Console.WriteLine("We'll start a new game ...");
                        Console.WriteLine();

                        int players = GetIntFromConsole("How many players are you?");
                        int rounds = GetIntFromConsole("How many rounds per player?");

                        playerRoundsScores = new int[players, rounds];

                        for (int i = 0; i < playerRoundsScores.GetLength(1); i++)
                        {
                            Console.WriteLine("Starting Round {0}", i + 1);
                            for (int j = 0; j < playerRoundsScores.GetLength(0); j++)
                            {
                                Console.WriteLine("Player {0}'s round: ", j + 1);
                                StartRound(j, i);
                            }
                        }

                        for (int i = 0; i < playerRoundsScores.GetLength(0); i++)
                        {
                            Console.WriteLine("Player: {0}", i + 1);
                            int totalScore = 0;
                            for (int j = 0; j < playerRoundsScores.GetLength(1); j++)
                            {
                                Console.WriteLine("Round: {0} / Score: {1}", j + 1, playerRoundsScores[i, j]);
                                totalScore += playerRoundsScores[i, j];
                            }
                            Console.WriteLine("Total Round Score: {0}", totalScore);
                        }



                        // TODO: consider how the leaderboard could look
                        // ... would it remember all players' rounds and scores
                        // ... or perhaps only the best player's score?

                        // TODO: sort the new leaderboard



                        //// prompt user for number of dice rolls
                        //Console.Write("How many times should we roll the dice? Times: ");
                        //Int32.TryParse(Console.ReadLine(), out int rolls);

                        //Console.WriteLine();

                        //// roll the dice and show results
                        //score = RollDice(rolls);

                        //// present tally
                        //Console.WriteLine();
                        //Console.WriteLine("Your score this round: {0}", score);

                        //// save to score board / array search
                        //UpdateLeaderboard(score);

                        //// sort the leaderboard / array sorting
                        //SortLeaderboard();

                        break;

                    // check score board
                    case 's':

                        Console.WriteLine("Let's see how good you were ...");

                        // access score array and show results
                        for (int i = 0; i < leaderBoard.Length; i++)
                        {
                            Console.WriteLine("#{0}. {1}", i + 1, leaderBoard[i]);
                        }

                        break;

                    // run quit sequence
                    case 'q':

                        Console.WriteLine("Sorry to see you go ...");

                        break;

                    // if none of the above cases are matched against the user's input...
                    default:

                        Console.WriteLine("Sorry, wrong input ...");

                        break;

                }

                Console.WriteLine();

                // don't show this prompt if they chose to quit
                if (userChoice != 'q')
                {
                    Console.WriteLine("Press any key to return to the Menu ...");
                    Console.ReadKey();
                }

                // end of the loop, check if it needs to run again
            } while (userChoice != 'q');

            // quit message
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }

        /// <summary>
        /// Shows the menu.
        /// </summary>
        public static void ShowMenu()
        {
            Console.WriteLine("n. New game");
            Console.WriteLine("s. Score board");
            Console.WriteLine("q. Quit");
            Console.WriteLine();
        }

        /// <summary>
        /// Gets and validates the user choice.
        /// </summary>
        /// <returns>The user choice.</returns>
        /// <param name="message">User prompt message.</param>
        public static char GetUserChoice(string message)
        {

            // get char
            char userChoice;
            bool allOk;

            // validate choice
            do
            {
                allOk = true;

                // get the input
                userChoice = GetChar(message);

                // check if it's correct
                if (
                    userChoice != 'n' &&    // new game
                    userChoice != 's' &&    // score board
                    userChoice != 'q'       // quit
                )
                {

                    Console.WriteLine();
                    Console.WriteLine("Unknown choice, please try again...");
                    Console.WriteLine();

                    allOk = false;

                }

            } while (!allOk);

            return userChoice;

        }

        /// <summary>
        /// Reads a char value from the console after prompting the user.
        /// </summary>
        /// <returns>The char.</returns>
        /// <param name="message">User prompt message.</param>
        public static char GetChar(string message)
        {

            Console.Write(message);
            char userChoice = Console.ReadKey().KeyChar.ToString().ToLower()[0];

            return userChoice;

        }

        /// <summary>
        /// Updates the leaderboard with a new score.
        /// </summary>
        /// <param name="newScore">New score.</param>
        public static void UpdateLeaderboard(int newScore)
        {

            // save to score board / array search
            for (int i = 0; i < leaderBoard.Length; i++)
            {
                // locate an empty
                if (leaderBoard[i] == 0)
                {
                    leaderBoard[i] = newScore;
                    break;
                }
            }

        }

        /// <summary>
        /// Sorts the leaderboard highest to lowest score.
        /// </summary>
        public static void SortLeaderboard()
        {

            // sort the leaderboard / array sorting
            for (int i = 0; i < leaderBoard.Length - 1; i++)
            {// first index

                for (int j = i + 1; j < leaderBoard.Length; j++)
                {// second index

                    // compare first and second values using the indices
                    if (leaderBoard[i] < leaderBoard[j])
                    {
                        // switch them around
                        int tmp = leaderBoard[i];
                        leaderBoard[i] = leaderBoard[j];
                        leaderBoard[j] = tmp;
                    }
                }
            }


        }

        /// <summary>
        /// Rolls the D6 dice several times.
        /// </summary>
        /// <returns>The score obtained from adding up all dice rolls.</returns>
        /// <param name="times">Times to roll.</param>
        public static int RollDice(int times)
        {

            int score = 0;

            for (int i = 0; i < times; i++)
            {
                // roll is the d6 array index, used below
                int roll = GenerateRandomNumberBetween(0, 5);

                Console.WriteLine("Rolled: {0}", d6[roll, 0]);

                score += d6[roll, 0];
            }

            return score;

        }

        /** Method Overloading
         */

        /// <summary>
        /// Generates the random number between 0 and max.
        /// </summary>
        /// <returns>The randomly generated <see cref="T:System.Int32"/>.</returns>
        /// <param name="max">Maximum (inclusive).</param>
        public static int GenerateRandomNumberBetween(int max)
        {

            return GenerateRandomNumberBetween(0, max);

        }

        /// <summary>
        /// Generates the random number between min and max.
        /// </summary>
        /// <returns>The randomly generated <see cref="T:System.Int32"/>.</returns>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum (inclusive).</param>
        public static int GenerateRandomNumberBetween(int min, int max)
        {

            return rng.Next(min, max + 1);

        }

        /// <summary>
        /// NOT IN USE. This one isn't currently being used, it's here for educational purposes.
        /// Generates the random number between min, max and message.
        /// </summary>
        /// <returns>The <see cref="T:System.Int32"/>.</returns>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Max.</param>
        /// <param name="message">Message.</param>
        public static int GenerateRandomNumberBetween(int min, int max, string message)
        {

            Console.WriteLine(message);

            return GenerateRandomNumberBetween(min, max);
        }

        /// <summary>
        /// NOT IN USE. This one isn't currently being used, it's here for educational purposes.
        /// Generates the random number between message, min and max.
        /// </summary>
        /// <returns>The <see cref="T:System.Int32"/>.</returns>
        /// <param name="message">Message.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Max.</param>
        public static int GenerateRandomNumberBetween(string message, int min, int max)
        {

            Console.WriteLine(message);

            return GenerateRandomNumberBetween(min, max);
        }

        public static int GetIntFromConsole(string message)
        {

            Console.Write(message);
            Int32.TryParse(Console.ReadLine(), out int rolls);

            return rolls;

        }

        public static void StartRound(int player, int round)
        {

            Console.Write("How many times should we roll the dice? Times: ");
            Int32.TryParse(Console.ReadLine(), out int rolls);

            playerRoundsScores[player, round] = RollDice(rolls);

        }

    }
}
