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

namespace ComputingGraphicsFinalProject
{
    public partial class Form1 : Form
    {
        SolidBrush brushLightblue = new SolidBrush(Color.LightBlue);
        SolidBrush brushGrey = new SolidBrush(Color.Gray);
        Pen penBlack = new Pen(Color.Black);

        int windowWidth;
        int windowHeight;

        
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.White;
            /*
             * needs:
             * grey box across the top
             * grey box down the right hand side
             * drop down menu for drawing shapes:
             * circle
             * triangle
             * square
             * 
             * list of the shapes drawn down the right hand side
             * delete button 
             * 
             * class called shape
             * subclass of the name of the shape
             * 
             */

        }

        private void drawMenuBoxes(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle menuBar = new Rectangle(10, 10, 50, 50);

            g.DrawRectangle(penBlack, menuBar);
            g.FillRectangle(brushGrey, menuBar);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            windowWidth = this.Width;
            windowHeight = this.Height;




        }







    }
}
