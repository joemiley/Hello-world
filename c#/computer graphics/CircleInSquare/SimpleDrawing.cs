using System;
using System.Drawing;
using System.Windows.Forms;

namespace CGP
{
    public partial class SimpleDrawing : Form
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SimpleDrawing());
        }
        public SimpleDrawing()
        {

            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Width = 500;
            this.Height = 500;
            this.BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Create a pen object
            Pen blackPen = new Pen(Color.Black);

            // Draws a triangle 
            g.DrawLine(blackPen, 50, 50, 100, 100);
            g.DrawLine(blackPen, 100, 100, 200, 100);
            g.DrawLine(blackPen, 50, 50, 100, 100);
            g.DrawLine(blackPen, 200, 100, 50, 50);

            // Draw a rectangle
            g.DrawRectangle(blackPen, 200, 200, 150, 150);

            // Draw an ellipse
            g.DrawEllipse(blackPen, new Rectangle(250, 75, 100, 100));

            // Draw an ellipse within the square
            g.DrawEllipse(blackPen, new Rectangle(200, 200, 150, 150));

            // Define points of a polygon
            Point[] pts = {
                            new Point(50, 300),
                            new Point(150, 300),
                            new Point(150, 400),
                            new Point(100, 350),
                            new Point(50, 400)
                          };

            // Define a colour for filling the polygon
            Color myColour = Color.FromArgb(0, 255, 0);
            SolidBrush brush = new SolidBrush(myColour);

            // Draw filled polygon
            g.FillPolygon(brush, pts);
        }
    }
}