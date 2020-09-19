using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace matrix3
{
    class Program
    {
        public static Random Rng = new Random();
        public static Timer display = new Timer(1500);
        public static Timer creator = new Timer(750);
        public static List<String>[] list = new List<string>[168];

        static void Main(string[] args)
        {
            
            display.Enabled = true;
            creator.Enabled = true;

            display.AutoReset = true;
            creator.AutoReset = true;

            display.Elapsed += Display;
            creator.Elapsed += Creator;


            Console.ReadKey();
        }

        public static void Display (object source, ElapsedEventArgs e)
        {
            Console.Clear();
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i]);
            }
        }

        public static void Creator (object source, ElapsedEventArgs e)
        {
            string start = "0";
            if(list.Length <= 1)
            {
                list[0] = start;
            }

            for (int i = 1; i < list.Length; i++)
            {
                string inputCharacter = "";
                int rngGenerator = Rng.Next(0, 36);


                switch (rngGenerator)
                {
                    case 0:
                        inputCharacter = "a";
                        break;
                    case 1:
                        inputCharacter = "b";
                        break;
                    case 2:
                        inputCharacter = "c";
                        break;
                    case 3:
                        inputCharacter = "d";
                        break;
                    case 4:
                        inputCharacter = "e";
                        break;
                    case 5:
                        inputCharacter = "f";
                        break;
                    case 6:
                        inputCharacter = "g";
                        break;
                    case 7:
                        inputCharacter = "h";
                        break;
                    case 9:
                        inputCharacter = "i";
                        break;
                    case 10:
                        inputCharacter = "j";
                        break;
                    case 11:
                        inputCharacter = "k";
                        break;
                    case 12:
                        inputCharacter = "l";
                        break;
                    case 13:
                        inputCharacter = "m";
                        break;
                    case 14:
                        inputCharacter = "n";
                        break;
                    case 15:
                        inputCharacter = "o";
                        break;
                    case 16:
                        inputCharacter = "p";
                        break;
                    case 17:
                        inputCharacter = "q";
                        break;
                    case 18:
                        inputCharacter = "r";
                        break;
                    case 19:
                        inputCharacter = "s";
                        break;
                    case 20:
                        inputCharacter = "t";
                        break;
                    case 21:
                        inputCharacter = "u";
                        break;
                    case 22:
                        inputCharacter = "v";
                        break;
                    case 23:
                        inputCharacter = "w";
                        break;
                    case 24:
                        inputCharacter = "x";
                        break;
                    case 25:
                        inputCharacter = "y";
                        break;
                    case 26:
                        inputCharacter = "z";
                        break;
                    case 27:
                        inputCharacter = ",";
                        break;
                    case 28:
                        inputCharacter = "?";
                        break;
                    case 29:
                        inputCharacter = ".";
                        break;
                    case 30:
                        inputCharacter = " ";
                        break;
                    case 31:
                        inputCharacter = " ";
                        break;
                    case 32:
                        inputCharacter = " ";
                        break;
                    case 33:
                        inputCharacter = "(";
                        break;
                    case 34:
                        inputCharacter = ")";
                        break;
                    case 35:
                        inputCharacter = ";";
                        break;


                }

                list[i].Add(inputCharacter);


                if (list[i].Count == 10)
                {
                    list[i].RemoveAt(0);
                }

            }

        }
    }
}
