using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace workbench
{
    class Program
    {
        static Random RNG = new Random();
        public static Timer generator = new Timer(1000);
        static int counter =+ 0;




        static void Main(string[] args)
        {


            if (counter >= 20)
            {
              
                generator.Enabled = false;
                generator.AutoReset = false;


            }
            else
            {
                generator.Enabled = true;
                generator.AutoReset = true;
                generator.Elapsed += matrixGen;
            }


           



            Console.ReadKey();
        }



        public static void matrixGen (object source, ElapsedEventArgs e)
        {
            int randomnumbers;
            string convertion = "";


            //first for loop makes the spaces
            for (int i = 0; i < 10; i++)
            {
                randomnumbers = RNG.Next(1, 40);

                switch (randomnumbers)
                {
                    case 1:
                        convertion = "1";
                        break;

                    case 2:
                        convertion = "2";
                        break;

                    case 3:
                        convertion = "3";
                        break;

                    case 4:
                        convertion = "4";
                        break;

                    case 5:
                        convertion = "5";
                        break;

                    case 6:
                        convertion = "6";
                        break;

                    case 7:
                        convertion = "7";
                        break;

                    case 8:
                        convertion = "8";
                        break;

                    case 9:
                        convertion = "9";
                        break;

                    case 10:
                        convertion = "0";
                        break;

                    case 11:
                        convertion = "d";
                        break;

                    case 12:
                        convertion = "c";
                        break;

                    case 13:
                        convertion = "b";
                        break;

                    case 14:
                        convertion = "z";
                        break;

                    case 15:
                        convertion = "a";
                        break;

                    case 16:
                        convertion = "y";
                        break;

                    case 17:
                        convertion = "x";
                        break;

                    case 18:
                        convertion = "w";
                        break;

                    case 19:
                        convertion = "v";
                        break;

                    case 20:
                        convertion = "u";
                        break;

                    case 21:
                        convertion = "t";
                        break;

                    case 22:
                        convertion = "s";
                        break;

                    case 23:
                        convertion = "r";
                        break;

                    case 24:
                        convertion = "q";
                        break;

                    case 25:
                        convertion = "a";
                        break;

                    case 26:
                        convertion = "b";
                        break;

                    case 27:
                        convertion = "c";
                        break;

                    case 28:
                        convertion = "d";
                        break;

                    case 29:
                        convertion = "e";
                        break;

                    case 30:
                        convertion = "f";
                        break;

                    case 31:
                        convertion = "g";
                        break;

                    case 32:
                        convertion = "h";
                        break;

                    case 33:
                        convertion = "i";
                        break;

                    case 34:
                        convertion = "J";
                        break;

                    case 35:
                        convertion = "k";
                        break;

                    case 36:
                        convertion = "L";
                        break;

                    case 37:
                        convertion = "m";
                        break;

                    case 38:
                        convertion = "n";
                        break;

                    case 39:
                        convertion = "o";
                        break;

                    case 40:
                        convertion = "P";
                        break;
                }

                Console.Write(convertion);
            }

            Console.Write("     ");

            counter++;

            

        }

    }
}
