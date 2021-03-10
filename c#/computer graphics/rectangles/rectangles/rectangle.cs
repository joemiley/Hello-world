using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rectangles
{
    public partial class rectangle : Form
    {
        public rectangle()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);            // Specify form located top left origin of screen
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Width = 500;
            this.Height = 500;
            this.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;            // Create a pen for drawing
            Pen blackPen = new Pen(Color.Black);            // Draw a rectangle
            g.DrawRectangle(blackPen, 10, 10, 300, 300);            // Define a font and a brush for writing
            Font myFont = new System.Drawing.Font("Helvetica", 9);
            Brush blackwriter = new SolidBrush(System.Drawing.Color.Black);
            g.DrawString("First rectangle", myFont, blackwriter, 10, 10);            // Create a Rectangle object and draw it
            Rectangle r2 = new Rectangle(200, 30, 50, 50);
            g.DrawRectangle(blackPen, r2);
            g.DrawString("Second Rectangle", myFont, blackwriter, 200, 30);            // Redefine the position of the rectangle            
            r2.Location = new Point(20, 150);            // Create a green pen and brush
            Pen greenPen = new Pen(Color.Green, 5);
            Brush greenwriter = new SolidBrush(System.Drawing.Color.Green);            // Redraw the rectangle using green pen and brush
            g.DrawRectangle(greenPen, r2);
            g.DrawString("Third Rectangle", myFont, greenwriter, 20, 150);            // Enlarge rectangle by expanding 25 pixels in both directions on each axis
            r2.Inflate(25, 25); // width and height now 100x100            

            // Relocate enlarged rectangle            
            r2.Location = new Point(150, 150);            // Redraw enlarged rectangle at new position with black pen
            g.DrawRectangle(blackPen, r2);
            // Now fill the rectangle with a fancy gradient colour change from top left red to bottom right green            
            // Create a diagonal linear gradient from start to end points of pure colour               
            LinearGradientBrush gradient = new LinearGradientBrush(new Point( 150, 150 ), new Point(250, 250), Color.FromArgb(255, 255, 0, 0), Color.FromArgb(255, 0, 255, 0) );
            g.FillRectangle(gradient, r2);            // Use a new font and write italicised title over the rectangle
            Font newFont = new System.Drawing.Font("Georgia", 12, FontStyle.Italic);
            g.DrawString("Fourth Rectangle", newFont, blackwriter, 150, 150);        
        }
    }
}
