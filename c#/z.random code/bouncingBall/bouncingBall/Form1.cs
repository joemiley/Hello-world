using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bouncingBall
{
    public partial class Form1 : Form
    {
        //red ball
        private int rballWidth = 100;
        private int rballHeight = 100;
        private int rballPosX = 0;//keep at 0
        private int rballPosY = 0;//0
        private int rmoveStepX = 0;//3
        private int rmoveStepY = 3;//3

        //yellow ball
        private int yballWidth = 100;
        private int yballHeight = 100;
        private int yballPosX = 105; //105 to make a line(+100pixels to clear the ball and 5 for a space)
        private int yballPosY = 0;//0
        private int ymoveStepX = 0;//3
        private int ymoveStepY = 3;//3

        //green ball
        private int gballWidth = 100;
        private int gballHeight = 100;
        private int gballPosX = 210; // 210 (+100pixels to clear the ball and 5 for a space)
        private int gballPosY = 0;//0
        private int gmoveStepX = 0;//3
        private int gmoveStepY = 3;//3

        //blue ball
        private int bballWidth = 100;
        private int bballHeight = 100;
        private int bballPosX = 315; //315 (+100pixels to clear the ball and 5 for a space)
        private int bballPosY = 0;//0
        private int bmoveStepX = 0;//3
        private int bmoveStepY = 3;//3


        public Form1()
        {
            InitializeComponent();

            //makes the ball move smoother
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer 
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint, true);
            //updates the ball smoothness
            this.UpdateStyles();
        }

        private void paintCircle(object sender, PaintEventArgs e)
        {

            //background colour
            this.BackColor = Color.Black;
            //circle 1
            //smooths the graphics
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            //clears the graphic of the ball
            e.Graphics.Clear(this.BackColor);

            //fills the inside of the ball
            e.Graphics.FillEllipse(Brushes.Red, rballPosX, rballPosY, rballWidth, rballHeight);
            //gives the ball an outline
            e.Graphics.DrawEllipse(Pens.Black, rballPosX, rballPosY, rballWidth, rballHeight);

            //circle 2
            //fills the inside of the ball
            e.Graphics.FillEllipse(Brushes.Yellow, yballPosX, yballPosY, yballWidth, yballHeight);
            //gives the ball an outline
            e.Graphics.DrawEllipse(Pens.Black, yballPosX, yballPosY, yballWidth, yballHeight);

            //circle 3
            //fills the inside of the ball
            e.Graphics.FillEllipse(Brushes.Green, gballPosX, gballPosY, gballWidth, gballHeight);
            //gives the ball an outline
            e.Graphics.DrawEllipse(Pens.Black, gballPosX, gballPosY, gballWidth, gballHeight);

            //circle 4
            //fills the inside of the ball
            e.Graphics.FillEllipse(Brushes.Blue, bballPosX, bballPosY, bballWidth, bballHeight);
            //gives the ball an outline
            e.Graphics.DrawEllipse(Pens.Blue, bballPosX, bballPosY, bballWidth, bballHeight);


        }



        private void moveBall(object sender, EventArgs e)
        {
            //Red ball
            //update posistion X
            rballPosX += rmoveStepX;

            //reverse posistion so the ball doesnt go out of the window
            if ( rballPosX <0 ||  rballPosX + rballWidth > this.ClientSize.Width)
            {
                rmoveStepX = -rmoveStepX;
            }

            //update posistion Y
            rballPosY += rmoveStepY;

            //reverse posistion so the ball doesnt go out of the window
            if (rballPosY < 0 || rballPosY + rballHeight > this.ClientSize.Height)
            {
                rmoveStepY = -rmoveStepY;
            }



            //Yellow ball
            //update posistion X
            yballPosX += ymoveStepX;

            //reverse posistion so the ball doesnt go out of the window
            if (yballPosX < 0 || yballPosX + yballWidth > this.ClientSize.Width)
            {
                ymoveStepX = -ymoveStepX;
            }

            //update posistion Y
            yballPosY += ymoveStepY;

            //reverse posistion so the ball doesnt go out of the window
            if (yballPosY < 0 || yballPosY + yballHeight > this.ClientSize.Height)
            {
                ymoveStepY = -ymoveStepY;
            }



            //Green ball
            //update posistion X
            gballPosX += gmoveStepX;

            //reverse posistion so the ball doesnt go out of the window
            if (gballPosX < 0 || gballPosX + gballWidth > this.ClientSize.Width)
            {
                gmoveStepX = -gmoveStepX;
            }

            //update posistion Y
            gballPosY += gmoveStepY;

            //reverse posistion so the ball doesnt go out of the window
            if (gballPosY < 0 || gballPosY + gballHeight > this.ClientSize.Height)
            {
                gmoveStepY = -gmoveStepY;
            }



            //Blue ball
            //update posistion X
            bballPosX += bmoveStepX;

            //reverse posistion so the ball doesnt go out of the window
            if (bballPosX < 0 || bballPosX + bballWidth > this.ClientSize.Width)
            {
                bmoveStepX = -bmoveStepX;
            }

            //update posistion Y
            bballPosY += bmoveStepY;

            //reverse posistion so the ball doesnt go out of the window
            if (bballPosY < 0 || bballPosY + bballHeight > this.ClientSize.Height)
            {
                bmoveStepY = -bmoveStepY;
            }
            //update painting ball
            this.Refresh();

        }
    }
}
