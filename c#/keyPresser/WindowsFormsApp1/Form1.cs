using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random rng = new Random();


        public Form1()
        {
            InitializeComponent();
            timer1.Interval = rng.Next(100, 500);


        }

        private void button1Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }
}
