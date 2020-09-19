using System;
//have to use system.io for in and out file names
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//used to do a click with the mouse
using System.Runtime.InteropServices;


namespace Screen_Shot
{

    //the main goal of this program is to search through a screen, find a pixel colour and click on it
    public partial class Form1 : Form
    {
        // counter for the saving incrament so files dnt override eachother
        public int counter = +0;

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern bool SetCursorPos(int x, int y);C:\Users\Toshiba\Desktop\coding\Screen_Shot\Screen_Shot\Program.cs

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwflags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            counter_Number_label.Text = counter.ToString();
            //gives the screen dimentions
            Rectangle screen = Screen.GetBounds(Point.Empty);

            //using the bitmap function built in and naming it with the screen variable dimentions 
            using (Bitmap bitmap = new Bitmap(screen.Width, screen.Height))
            {
                //creating an image from the bitmap
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    //using the "CopyFromScreen" function to populate the bitmap
                    g.CopyFromScreen(Point.Empty, Point.Empty, screen.Size);
                }

                //saving the bitmap with a counter and a name
                bitmap.Save("screen_"+ counter.ToString() + ".PNG", System.Drawing.Imaging.ImageFormat.Png);

                /////////////////////////////////////////////////////////////////////////////////////////////////////
                //the file name you want to move
                string fileName = "screen_" + counter.ToString() + ".PNG";

                //where the original file is
                string sourcePath = @"C:\Users\Toshiba\Desktop\coding\Screen_Shot\Screen_Shot\bin\Debug\" + fileName;

                //where you would like to move the original file
                string targetPath = @"C:\Users\Toshiba\Desktop\coding\Screen_Shot\screen_shot_bin\" + fileName;


                //copies an existing file to a new address and will over write anything with the same name
                System.IO.File.Copy(sourcePath, targetPath, true);

                /////////////////////////////////////////////////////////////////////////////////////////////////////

                //delete file
                System.IO.File.Delete(sourcePath);

                //incrementing the counter
                counter++;


                //if it hits 10 it resets the counter
                if(counter > 10)
                {
                    counter = 0;
                }
            }
        }

        private void Button2findPixelLocation_MouseClick(object sender, MouseEventArgs e)
        {
            //got it (needs to have the file type at the end or its invalid(.PNG))
            string pictureFile1 = @"C:\Users\Toshiba\Desktop\coding\Screen_Shot\screen_shot_bin\screen_"+ counter.ToString()+".PNG";
            //save the picture as a bitmap so the file can look through it
            Bitmap b = new Bitmap(pictureFile1);

            //colours from paint
            int red = 173;
            int green = 171;
            int blue = 170;

            //use the colours to save to a full colour we can check against 
            Color specifiedColor = Color.FromArgb(red, green, blue);

            //the location of the pixel we want to chcek and the colour of that pixel
            for(int i = 0;i<1366; i++)
            {
                for( int j =0;j<768; j++)
                {
                    //lets itterate through the entire screen (the screen rez will change with different monitors
                    Color targetPixel = b.GetPixel(i, j);

                    //do they match. if so output true to both labels
                    if (targetPixel == specifiedColor)
                    {
                        output_number_label1.Text = i.ToString() + "," + j.ToString();

                        Cursor.Position = new Point(i, j);

                        this.Refresh();
                        Application.DoEvents();
                        mouse_event(MOUSEEVENTF_LEFTDOWN, i, j, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTUP, i, j, 0, 0);

                        //return means it only finds the first pixel
                        return;
                        //without return it will find all the pixels with that colour
                    }
                }
            }
        }

        private void Button3move_MouseClick(object sender, MouseEventArgs e)
        {
            //got it (needs to have the file type at the end or its invalid(.PNG))
            string pictureFile1 = @"C:\Users\Toshiba\Desktop\coding\Screen_Shot\screen_shot_bin\screen_" + counter.ToString() + ".PNG";
            //save the picture as a bitmap so the file can look through it
            Bitmap b = new Bitmap(pictureFile1);

            //colours from paint
            int red =173;
            int green = 171;
            int blue = 170;

            //use the colours to save to a full colour we can check against 
            Color specifiedColor = Color.FromArgb(red, green, blue);

            //the location of the pixel we want to chcek and the colour of that pixel
            for (int i = 0; i < 1366; i++)
            {
                for (int j = 0; j < 768; j++)
                {
                    //lets itterate through the entire screen (the screen rez will change with different monitors
                    Color targetPixel = b.GetPixel(i, j);

                    //do they match. if so output true to both labels
                    if (targetPixel == specifiedColor)
                    {
                        output_number_label1.Text = i.ToString() + "," + j.ToString();

                        Cursor.Position = new Point(i, j);

                        this.Refresh();
                        Application.DoEvents();
                        mouse_event(MOUSEEVENTF_RIGHTDOWN, i, j, 0, 0);
                        mouse_event(MOUSEEVENTF_RIGHTUP, i, j, 0, 0);

                        //return means it only finds the first pixel
                        return;
                        //without return it will find all the pixels with that colour
                    }
                }
            }
        }
    }
}
