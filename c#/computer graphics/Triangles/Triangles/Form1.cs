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

namespace Triangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            // Create a pen object
            Pen blackPen = new Pen(Color.Black);

            drawTriangles(8, e);
            
        }

        public static float ToSingle(double value)
        {
            return (float)value;
        }

        public static void drawTriangles (int amountOfTriangles, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black);

            int x1 = 500;
            int y1 = 100;

            int x2 = 100;
            int y2 = 100;

            int x3 = 300;
            int y3 = 446;

            for (int i = 0; i < amountOfTriangles; i++)
            {
                
                SolidBrush greenBrush = new SolidBrush(Color.Blue);

                g.DrawLine(blackPen, x1, y1, x2, y2);
                g.DrawLine(blackPen, x2, y2, x3, y3);
                g.DrawLine(blackPen, x3, y3, x1, y1);

                // mid point 1
                int copyx1 = (x1 + x2) / 2;
                int copyy1 = (y1 + y2) / 2;

                // mid point 2
                int copyx2 = (x1 + x3) / 2;
                int copyy2 = (y3 + y1) / 2;

                // midpoint 3
                int copyx3 = (x2 + x3) / 2;
                int copyy3 = (y2 + y3) / 2;

                x1 = copyx1;
                x2 = copyx2;
                x3 = copyx3;
                y1 = copyy1;
                y2 = copyy2;
                y3 = copyy3;

            }
        }

    }
}
