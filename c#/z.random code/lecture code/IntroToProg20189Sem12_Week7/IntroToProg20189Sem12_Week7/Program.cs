using System;

namespace IntroToProg20189Sem12_Week7
{
    class MainClass
    {
        public static void Main(string[] args)
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

            // NOTE: Visual Studio will suggest you remove the bits between = and {
            // That can be done, as the contents between the {} is used to
            // infer the "new int[3]" part
            int[] leaderBoard = new int[3] { 0, 0, 0 };

            /**
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
            int[,] d6 = new int[6, 1] {
                { 1 },
                { 2 },
                { 3 },
                { 4 },
                { 5 },
                { 6 }
            };

            // store the user menu choice
            char userChoice;
            // store the current game score
            int score;
            // random number generator, used to generate dice rolls
            Random rng = new Random();

            // looping structure
            do
            {

                // empty the window contents 
                // NOTE: Technically, it just inserts lots of empty lines really quickly
                // Feel free to scroll up ...
                Console.Clear();

                // menu
                Console.WriteLine("n. New game");
                Console.WriteLine("s. Score board");
                Console.WriteLine("q. Quit");
                Console.WriteLine("");

                // prompt for user choice
                Console.Write("Please choose one: ");
                userChoice = Console.ReadKey().KeyChar.ToString().ToLower()[0];

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

                        // prompt user for number of dice rolls
                        Console.Write("How many times should we roll the dice? Times: ");
                        Int32.TryParse(Console.ReadLine(), out int rolls);

                        Console.WriteLine();

                        // set up the score variable
                        score = 0;

                        // roll the dice and show results
                        for (int i = 0; i < rolls; i++)
                        {
                            int roll = rng.Next(0, 6);

                            Console.WriteLine("Rolled: {0}", d6[roll, 0]);

                            score += d6[roll, 0];
                        }

                        // present tally
                        Console.WriteLine();
                        Console.WriteLine("Your score this round: {0}", score);

                        // save to score board / array search
                        for (int i = 0; i < leaderBoard.Length; i++)
                        {
                            // locate an empty
                            if (leaderBoard[i] == 0)
                            {
                                leaderBoard[i] = score;
                                break;
                            }
                        }

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

                    case 'q':

                        Console.WriteLine("Sorry to see you go ...");

                        break;

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
    }
}
