using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace colourRing
{
    class Program
    {
        static Random RNG = new Random();

        static Timer display = new Timer(2000);


        static void Main(string[] args)
        {

            display.Enabled = true;
            display.AutoReset = true;
            display.Elapsed += Display;

            Console.ReadKey();



        }

        public static void Display(object source, ElapsedEventArgs e)
        {
            Console.Clear();
            rings();


        }

        public static void rings()
        {
            for( int i = 0; i < 1; i++)
            {
                int random_Colour;

                random_Colour = RNG.Next(0, 4);

                switch (random_Colour)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;

                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                }

                Console.WriteLine("         00000000000000       ");
                Console.WriteLine("       000000000000000000     ");
                Console.WriteLine("      00000000000000000000    ");
                Console.WriteLine("     0000000000000000000000   ");
                Console.WriteLine("    000000000       00000000  ");
                Console.WriteLine("   000000000         00000000 ");
                Console.WriteLine("   000000000         00000000 ");
                Console.WriteLine("    000000000       00000000  ");
                Console.WriteLine("     0000000000000000000000   ");
                Console.WriteLine("      00000000000000000000    ");
                Console.WriteLine("       000000000000000000     ");
                Console.WriteLine("         00000000000000       ");
                Console.WriteLine("                              ");



            }

        }

    
    }
}
