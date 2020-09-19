using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace matrix
{
    class Program
    {
        //random number generator we will be using per
        //space on the screen
        static Random rng = new Random();

        static List<int> column1 = new List<int>();
        static List<int> column2 = new List<int>();
        static List<int> column3 = new List<int>();
        static List<int> column4 = new List<int>();
        static List<int> column5 = new List<int>();
        static List<int> column6 = new List<int>();
        static List<int> column7 = new List<int>();
        static List<int> column8 = new List<int>();
        static List<int> column9 = new List<int>();
        static List<int> column10= new List<int>();
        static List<int> column11= new List<int>();
        static List<int> column12= new List<int>();
        static List<int> column13= new List<int>();
        static List<int> column14= new List<int>();
        static List<int> column15= new List<int>();
        static List<int> column16 = new List<int>();
        static List<int> column17 = new List<int>();
        static List<int> column18 = new List<int>();
        static List<int> column19 = new List<int>();
        static List<int> column20 = new List<int>();
        static List<int> column21 = new List<int>();
        static List<int> column22 = new List<int>();
        static List<int> column23 = new List<int>();
        static List<int> column24 = new List<int>();
        static List<int> column25 = new List<int>();
        static List<int> column26 = new List<int>();
        static List<int> column27 = new List<int>();
        static List<int> column28 = new List<int>();

        static Timer timer_Creation = new Timer(150);
        static Timer timer_Display = new Timer(350);

        static void Main(string[] args)
        {
            timer_Creation.Enabled = true;
            timer_Display.Enabled = true;

            timer_Creation.AutoReset = true;
            timer_Display.AutoReset = true;

            timer_Creation.Elapsed += creation;
            timer_Display.Elapsed += display;

            Console.ReadKey();
        }

        public static void creation(object source, EventArgs e)
        {

            int type1 = rng.Next(0, 2);
            int type2 = rng.Next(0, 2);
            int type3 = rng.Next(0, 2);
            int type4 = rng.Next(0, 2);
            int type5 = rng.Next(0, 2);
            int type6 = rng.Next(0, 2);
            int type7 = rng.Next(0, 2);
            int type8 = rng.Next(0, 2);
            int type9 = rng.Next(0, 2);
            int type10 = rng.Next(0, 2);
            int type11 = rng.Next(0, 2);
            int type12 = rng.Next(0, 2);
            int type13 = rng.Next(0, 2);
            int type14 = rng.Next(0, 2);
            int type15 = rng.Next(0, 2);
            int type16 = rng.Next(0, 2);
            int type17 = rng.Next(0, 2);
            int type18 = rng.Next(0, 2);
            int type19 = rng.Next(0, 2);
            int type20 = rng.Next(0, 2);
            int type21 = rng.Next(0, 2);
            int type22 = rng.Next(0, 2);
            int type23 = rng.Next(0, 2);
            int type24 = rng.Next(0, 2);
            int type25 = rng.Next(0, 2);
            int type26 = rng.Next(0, 2);
            int type27 = rng.Next(0, 2);
            int type28 = rng.Next(0, 2);

            column1.Add(type1);
            column2.Add(type2);
            column3.Add(type3);
            column4.Add(type4);
            column5.Add(type5);
            column6.Add(type6);
            column7.Add(type7);
            column8.Add(type8);
            column9.Add(type9);
            column10.Add(type10);
            column11.Add(type11);
            column12.Add(type12);
            column13.Add(type13);
            column14.Add(type14);
            column15.Add(type15);
            column16.Add(type16);
            column17.Add(type17);
            column18.Add(type18);
            column19.Add(type19);
            column20.Add(type20);
            column21.Add(type21);
            column22.Add(type22);
            column23.Add(type23);
            column24.Add(type24);
            column25.Add(type25);
            column26.Add(type26);
            column27.Add(type27);
            column28.Add(type28);

            if(column1.Count == 44) {
                column1.RemoveAt(0);
            }
            if (column2.Count == 44) {
                column2.RemoveAt(0);
            }
            if (column3.Count == 44) {
                column3.RemoveAt(0);
            }
            if (column4.Count == 44) {
                column4.RemoveAt(0);
            }
            if (column5.Count == 44) {
                column5.RemoveAt(0);
            }
            if (column6.Count == 44) {
                column6.RemoveAt(0);
            }
            if (column7.Count == 44) {
                column7.RemoveAt(0);
            }
            if (column8.Count == 44) {
                column8.RemoveAt(0);
            }
            if (column9.Count == 44) {
                column9.RemoveAt(0);
            }
            if (column10.Count == 44) {
                column10.RemoveAt(0);
            }
            if (column11.Count == 44) {
                column11.RemoveAt(0);
            }
            if (column12.Count == 44) {
                column12.RemoveAt(0);
            }
            if (column13.Count == 44) {
                column13.RemoveAt(0);
            }
            if (column14.Count == 44) {
                column14.RemoveAt(0);
            }
            if (column15.Count == 44) {
                column15.RemoveAt(0);
            }
            if (column16.Count == 44) {
                column16.RemoveAt(0);
            }
            if (column17.Count == 44) {
                column17.RemoveAt(0);
            }
            if (column18.Count == 44) {
                column18.RemoveAt(0);
            }
            if (column19.Count == 44) {
                column19.RemoveAt(0);
            }
            if (column20.Count == 44) {
                column20.RemoveAt(0);
            }
            if (column21.Count == 44) {
                column21.RemoveAt(0);
            }
            if (column22.Count == 44) {
                column22.RemoveAt(0);
            }
            if (column23.Count == 44) {
                column23.RemoveAt(0);
            }
            if (column24.Count == 44) {
                column24.RemoveAt(0);
            }
            if (column25.Count == 44) {
                column25.RemoveAt(0);
            }
            if (column26.Count == 44) {
                column26.RemoveAt(0);
            }
            if (column27.Count == 44) {
                column27.RemoveAt(0);
            }
            if (column28.Count == 44) {
                column28.RemoveAt(0);
            }




        }


        public static void display(object source, EventArgs e)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < column1.Count; i++)
            {
                Console.WriteLine(column1[i] + " "+ column2[i] + "  " + column3[i] + "  " + column4[i] + "   " + column5[i] + "   " + column6[i] +
                    "    " + column7[i] + "    " + column8[i] + "     " + column9[i] + "     " + column10[i] + "      " + column11[i] + "      " + column12[i] +
                    "        " + column13[i] + "              " + column14[i] + "               "+ column15[i] + "          " + column16[i] + "      " + column17[i] + "      " + column18[i] + "     " + column19[i] + "     " + column6[i] +
                    "     " + column20[i] + "    " + column21[i] + "    " + column22[i] + "    " + column23[i] + "   " + column24[i] + "   " + column25[i] +
                    "  " + column26[i] + "  " + column27[i] + " " + column28[i]);
                
            }


        }
    }
}
