using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shape_representation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);

            // Define points of a polygon
            Point[] pts = {            
               //                      
                            new Point( 50, 50 ),
                            new Point(200, 50 ),
                            new Point(200, 90 ),
                            new Point(150, 90 ),
                            new Point(150, 120),
                            new Point(200, 120),
                            new Point(200, 150),
                            new Point( 50, 150),
                            new Point(150, 50 ),
                            new Point( 50, 120)

                          };

            int[,] linetable = new int[2,30];

            Point[,] lineTable = new Point[2, 30];
            //                 pt1                         pt2
            lineTable[0, 0] = pts[0]; lineTable[1, 0] = pts[1];
            lineTable[0, 1] = pts[1]; lineTable[1, 1] = pts[2];
            lineTable[0, 2] = pts[2]; lineTable[1, 2] = pts[3];
            lineTable[0, 3] = pts[3]; lineTable[1, 3] = pts[4];
            lineTable[0, 4] = pts[4]; lineTable[1, 4] = pts[5];
            lineTable[0, 5] = pts[5]; lineTable[1, 5] = pts[6];
            lineTable[0, 6] = pts[6]; lineTable[1, 6] = pts[7];
            lineTable[0, 7] = pts[7]; lineTable[1, 7] = pts[0];
            lineTable[0, 8] = pts[3]; lineTable[1, 8] = pts[8];
            lineTable[0, 9] = pts[4]; lineTable[1, 9] = pts[9];

            for (int i = 0; i < 10; i++)
            {
                g.DrawLine(pen, lineTable[0,i], lineTable[1,i]);
            }


                        
        }
    }
}
