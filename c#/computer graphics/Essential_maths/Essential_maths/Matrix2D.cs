using System;
using System.Collections.Generic;
using System.Text;

namespace Essential_maths
{
    class Matrix2D
    {

        public int[,] matrix { get; set; }

        public int Width { get; set; }

        public int Depth { get; set; }

        public Matrix2D (int[,] mtx , int w, int d)
        {
            matrix = mtx;
            Width = w;
            Depth = d;
        }

    }
}
