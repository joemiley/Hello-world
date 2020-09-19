using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madlibs1
{
    class Program
    {
        static void Main(string[] args)
        {

                string[] userInput = new string[15];
                Console.WriteLine();
                Console.WriteLine(@"             ███╗   ███╗ █████╗ ██████╗ ██╗     ██╗██████╗ ███████╗");
                Console.WriteLine(@"             ████╗ ████║██╔══██╗██╔══██╗██║     ██║██╔══██╗██╔════╝");
                Console.WriteLine(@"             ██╔████╔██║███████║██║  ██║██║     ██║██████╔╝███████╗");
                Console.WriteLine(@"             ██║╚██╔╝██║██╔══██║██║  ██║██║     ██║██╔══██╗╚════██║");
                Console.WriteLine(@"             ██║ ╚═╝ ██║██║  ██║██████╔╝███████╗██║██████╔╝███████║");
                Console.WriteLine(@"             ╚═╝     ╚═╝╚═╝  ╚═╝╚═════╝ ╚══════╝╚═╝╚═════╝ ╚══════╝");
                Console.WriteLine();

                Console.WriteLine(" enter a verb (doing an action)");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput[0] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" enter a adjective (description of something)");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput[1] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" enter a plural noun (more than one of something)");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput[2] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" enter a adjective (description of something)");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput[3] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" enter a verb ending in 'ing'(doing an action)");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput[4] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" enter a verb (doing an action)");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput[5] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" enter a number (duh)");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput[6] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" enter a adjective (description of something)");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput[7] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" enter a plural noun (more than one of something)");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput[8] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" enter a plural noun (more than one of something)");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput[9] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" enter a plural noun (more than one of something)");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput[10] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" enter a plural relatives (e.g parents, sisters) ");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput[11] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" enter a adjective (description of something)");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput[12] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" enter a adjective (description of something)");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput[13] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" enter a adjective (description of something)");
                Console.ForegroundColor = ConsoleColor.Red;
                userInput[14] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("are you ready? hit enter when ready");

                Console.Clear();

                //welcome to walmart
                Console.WriteLine(@"           __          __  _                             _         __          __   _                      _  ");
                Console.WriteLine(@"           \ \        / / | |                           | |        \ \        / /  | |                    | |  ");
                Console.WriteLine(@"            \ \  /\  / /__| | ___ ___  _ __ ___   ___   | |_ ___    \ \  /\  / /_ _| |_ __ ___   __ _ _ __| |_ ");
                Console.WriteLine(@"             \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \  | __/ _ \    \ \/  \/ / _` | | '_ ` _ \ / _` | '__| __|");
                Console.WriteLine(@"              \  /\  /  __/ | (_| (_) | | | | | |  __/  | || (_) |    \  /\  / (_| | | | | | | | (_| | |  | |_ ");
                Console.WriteLine(@"               \/  \/ \___|_|\___\___/|_| |_| |_|\___|   \__\___/      \/  \/ \__,_|_|_| |_| |_|\__,_|_|   \__|");

                Console.WriteLine();


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Come [" + userInput[0] + "] at WALMART, where you`ll receive [" + userInput[1] + "] discounts on all of your favorite brand name [" + userInput[2] + "]. Our [" + userInput[3] + "] and [" + userInput[4] + "] associates are there to [" + userInput[5] + "] you [" + userInput[6] + "] hours a day. Here you will find [" + userInput[7] + "] prices on the [" + userInput[8] + "] you need. [" + userInput[9] + "] for the moms, [" + userInput[10] + "] for the kids and all the latest electronics for the [" + userInput[11] + "]. So come on down to your [" + userInput[12] + "] [" + userInput[13] + "] WALMART where the [" + userInput[14] + "] come first.	");


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"                                                           /$$ /$$           _                           _                   ");
                Console.WriteLine(@"                                                          / $$/ $$          |  we hope you liked our game |                  ");
                Console.WriteLine(@"                                            / $$$$$$$   /$$$$$$$$$$            talk to the team for more                     ");
                Console.WriteLine(@"                                           /  $$_____/  |   $$  $$_/           info if you are looking to                    ");
                Console.WriteLine(@"                                           |  $$        /$$$$$$$$$$            join up!                                      ");
                Console.WriteLine(@"                                           |  $$        |_  $$  $$_/        |_                           _|                  ");
                Console.WriteLine(@"                                           |  $$$$$$$     | $$| $$                                                           ");
                Console.WriteLine(@"                                           \_______ /     |__/|__/                                                           ");


                Console.ReadKey();
            Console.Clear();


            
        }
    }
}
