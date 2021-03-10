using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_maths
{
    class Program
    {
        public static Random rng = new Random();

        static List<Matrix2D> MatrixList = new List<Matrix2D>();

        static void Main(string[] args)
        {
            for(int i = 0; i < 2; i++)
            {
                Matrix2DSpawn();
            }

            Console.WriteLine("matrix a");
            for (int i = 0; i < MatrixList[0].Width; i++)
            {
                for(int j = 0; j< MatrixList[0].Depth; j++)
                {
                    Console.Write(MatrixList[0].matrix[i,j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("matrix b");
            for (int i = 0; i < MatrixList[1].Width; i++)
            {
                for (int j = 0; j < MatrixList[1].Depth; j++)
                {
                    Console.Write(MatrixList[1].matrix[i, j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("C:");
            Multiplies(MatrixList[0].matrix, MatrixList[1].matrix);

        }

        public static void Matrix2DSpawn()
        {
            int[,] internalMatrix = new int[2, 2];
            Matrix2D MatrixInstance = null;

            internalMatrix[0, 0] = rng.Next(0, 10);
            internalMatrix[0, 1] = rng.Next(0, 10);
            internalMatrix[1, 0] = rng.Next(0, 10);
            internalMatrix[1, 1] = rng.Next(0, 10);

            int matrixWidth = 2;
            int matrixDepth = 2;

            MatrixInstance = new Matrix2D(internalMatrix, matrixWidth, matrixDepth);

            MatrixList.Add(MatrixInstance);

        }

        public static void Multiplies(int[,] a, int[,] b)
        {
            int[,] c = new int[a.GetLength(0),a.GetLength(1)];

            for(int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j <a.GetLength(1); j++)
                {
                    c[i, j] = a[i, j] * b[i, j];
                    Console.Write(i + "," + j + " = " + c[i, j] + "      ");
                }
            }
        }
    }
}
