using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XORDrawing
{

    public partial class Form1 : Form
    {
        public int x = 0;
        public int y = 0;

        Rectangle aRect;
        Rectangle anEllipse;
        Rectangle moving;
        
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            // set up the rectangle objects using client (form) coordinates

            aRect = new Rectangle(122, 99, 200, 200);
            anEllipse = new Rectangle(150, 150, 200, 100);



            // size and position the frame
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Width = 500;
            this.Height = 500;
            this.BackColor = Color.White;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;
            // Create a red brush
            Brush redBrush = new SolidBrush(Color.Red);
            // Fill rectangle 
            g.FillRectangle(redBrush, aRect);
            // Create a green brush
            Brush greenBrush = new SolidBrush(Color.Green);
            // Fill ellipse 
            g.FillEllipse(greenBrush, anEllipse);


            do
            {
                moving = new Rectangle(x, y, 10, 10);

                this.PointToScreen(new Point(x, y));

                ControlPaint.FillReversibleRectangle(moving, Color.Red);

                Thread.Sleep(500);

                //ControlPaint.FillReversibleRectangle(moving, Color.Red);

                x += 10;
                y += 10;

            } while (x < 500);
        }
    }
}
