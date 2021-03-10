using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Flicker
{
    public partial class Form1 : Form
    {
        
        Rectangle rect;
        int x = 0;
        int y = 0;
        int forever = 0;

        public Form1()
        {
            InitializeComponent();
            // Position the form
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            // Size the form
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Width = 400;
            this.Height = 400;
            // Create the small rectangle objects using client (form) coordinates
            rect = new Rectangle(x, y, 50, 50);
            updateGraphicsBuffer();


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Create a black pen and white and a red brush
            Pen blackPen = new Pen(Color.Black);
            Brush redBrush = new SolidBrush(Color.Red);
            Brush whiteBrush = new SolidBrush(Color.White);

            Bitmap backBuf = new Bitmap(this.Width, this.Height);
            Graphics g2 = Graphics.FromImage(backBuf);
            g2.FillRectangle(redBrush, rect);//etc;
            g.DrawImage(backBuf, 0, 0);

            // Define a font for writing
            Font myFont = new System.Drawing.Font("Helvetica", 9);

            string xMove = "right";
            string yMove = "down";

            do
            {
                // Define and fill large rectangle background 
                g.FillRectangle(whiteBrush, 0, 0, 400, 400);
                // Redefine the position of the small rectangle
                rect.Location = new Point(x, y);
                // Draw small rectangle in new position 
                g.DrawRectangle(blackPen, rect);
                // Display message always in same position
                g.DrawString("Moving rectangle", myFont, redBrush, 150, 150);


                Thread.Sleep(10);
                
                if ( xMove == "right")
                {
                    x++;
                    if (x == 333)
                    {
                        xMove = "left";
                    }
                }

                if (xMove == "left")
                {
                    x--;
                    if (x == 0)
                    {
                        xMove = "right";
                    }
                }

                if (yMove == "down")
                {
                    y++;
                    if (y == 315)
                    {
                        yMove = "up";
                    }
                }

                if (yMove == "up")
                {
                    y--;
                    if (y == 0)
                    {
                        yMove = "down";
                    }
                }


            } while (forever != 1);
        }

        public void updateGraphicsBuffer()
        {
            BufferedGraphicsContext bufferContex = BufferedGraphicsManager.Current;
        }

    }
    
}
