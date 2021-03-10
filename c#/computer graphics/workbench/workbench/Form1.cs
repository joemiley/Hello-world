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

namespace workbench
{
    public partial class Form1 : Form
    {

        static int Angle = 0;
        static List<Tmatrix> TmatrixList = new List<Tmatrix>();
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            // Specify form located top left origin of screen
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Width = 500;
            this.Height = 500;
            this.BackColor = Color.White;


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Create a pen for drawing
            Pen blackPen = new Pen(Color.Black);

            // Define a font and a brush for writing
            Font myFont = new System.Drawing.Font("Helvetica", 9);
            Brush blackwriter = new SolidBrush(System.Drawing.Color.Black);

            // Create and draw a rectangle
            Rectangle rect = new Rectangle(150, 100, 70, 70);
            g.DrawRectangle(blackPen, rect);
            g.DrawString("1st pos", myFont, blackwriter, rect.Left, rect.Bottom);
            // Record center of rectangle
            PointF center = new PointF(rect.X + (rect.Width / 2.0F),rect.Y + (rect.Height / 2.0F));

            // Implement transformations using the Matrix class
            Matrix myMatrix = new Matrix();

            // Rotate clockwise around world origin upper left 0, 0 
            myMatrix.Rotate(10);
            g.Transform = myMatrix;
            g.DrawRectangle(blackPen, rect);
            g.DrawString("2nd pos", myFont, blackwriter, rect.Right, rect.Bottom);

            int rectWidth = 70;
            int rectHeight = 70;

            for (int i = 0; i < 5; i++)
            {
                Angle += 35;
                RectangleRotator();
            }

            for (int i = 0; i < TmatrixList.Count; i++)
            {
                
                PointF centre = new PointF(TmatrixList[i].XCord + (rectWidth / 2.0F), TmatrixList[i].YCord + (rectHeight / 2.0F));
                Matrix myMatrix2 = new Matrix();
                // Rotate clockwise around world origin upper left 0, 0 
                myMatrix2.RotateAt(TmatrixList[i].RotationAngle,centre, MatrixOrder.Append);
                g.Transform = myMatrix2;
                g.DrawRectangle(blackPen, new Rectangle(TmatrixList[i].XCord, TmatrixList[i].YCord, rectWidth, rectHeight));
            }
        }

        public static void RectangleRotator()
        {
            
            int angle = Angle;
            int xCordinate = 200;
            int yCordinate = 250;

            Tmatrix T = null;
            T = new Tmatrix(angle, xCordinate, yCordinate);
            TmatrixList.Add(T);

        }
    }
}


