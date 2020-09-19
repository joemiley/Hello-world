using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();

        //clock size
        int width = 300;
        int height = 300;
        //hand lengths
        int secondHand = 140;
        int minHand = 110;
        int hrHand = 80;

        //centring the clock
        int cx;
        int cy;

        Bitmap bmp;
        Graphics G;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create a bitmap
            bmp = new Bitmap(width + 1, height + 1);

            //centre
            cx = width / 2;
            cy = height / 2;

            //back colour
            this.BackColor = Color.Khaki;

            //timers
            //create an interval of 1 second
            timer.Interval = 1000;
            timer.Tick += new EventHandler(this.timer_Tick);
            //starts the timer
            timer.Start();
        }

        //method to create graphics
        private void timer_Tick(object source,EventArgs e)
        {

            G = Graphics.FromImage(bmp);
            int sec = DateTime.Now.Second;
            int min = DateTime.Now.Minute;
            int hours = DateTime.Now.Hour;

            int[] handCoord = new int[2];

            //clear
            G.Clear(Color.Khaki);

            //draw the circle
            G.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, width, height);

            //draw figure
            //12
            G.DrawString("12 time to code", new Font("Arial", 12), Brushes.Black, new PointF(100, 15));//y,x
            //3
            G.DrawString("3 time to code", new Font("Arial", 12), Brushes.Black, new PointF(195, 140));//y,x
            //6
            G.DrawString("6 time to code", new Font("Arial", 12), Brushes.Black, new PointF(100, 262));//y,x
            //9
            G.DrawString("9 time to code", new Font("Arial", 12), Brushes.Black, new PointF(10, 140));//y,x

            //second hand
            handCoord = msCoord(sec, secondHand);
            G.DrawLine(new Pen(Color.Red, 1f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            //min hand
            handCoord = msCoord(min, minHand);
            G.DrawLine(new Pen(Color.Black, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            //hour hand
            handCoord = hrCoord(hours%12 ,min , hrHand);
            G.DrawLine(new Pen(Color.Gray, 3f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            //loading the bitmap into the picture box
            pictureBox2.Image = bmp;

            //display the time
            this.Text = "Clock" + hours + ":" + min + ":" + sec;

            //dispose
            G.Dispose();

        }

        //method for the minute hand
        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];

            //each min a nd second make 6 degrees of movement in the hands
            val *= 6;

            if(val >-0 && val < -180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }

            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;


        }

        //coord for hour ahnd
        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];

            //each hour makes 30 degrees
            //each min makes 0.5 degrees
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val > -0 && val < -180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }

            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;


        }

    }
}
