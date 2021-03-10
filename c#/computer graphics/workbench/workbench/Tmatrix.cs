using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace workbench
{

    class Tmatrix
    {
        public int RotationAngle { get; set; }

        public int XCord { get; set; }

        public int YCord { get; set; }



        public Tmatrix(int A, int X, int Y)
        {
            RotationAngle = A;
            XCord = X;
            YCord = Y;
        }


    }
}
