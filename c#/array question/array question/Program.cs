using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Linq;

namespace array_question
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 123
             * 456
             * 989     add the diagonals (159) and (357)
             */

            int[,] array = new int[3, 3] ;
            array[0, 0] = 1;
            array[0, 1] = 2;
            array[0, 2] = 3;
            array[1, 0] = 4;
            array[1, 1] = 5;
            array[1, 2] = 6;
            array[2, 0] = 9;
            array[2, 1] = 8;
            array[2, 2] = 9;

            int pos1a = 0;
            int pos1b = 0;


            int diag1 = array[pos1a, pos1b] + array[pos1a + 1, pos1b + 1] + array[pos1a + 2, pos1b + 2];
            int diag2 = array[pos1a + 2, pos1b] + array[pos1a + 1, pos1b + 1] + array[pos1a, pos1b + 2];
            int diagSum = diag2 - diag1;


            Console.WriteLine(diag1 + " " + diag2);
            Console.WriteLine("the diagonal difference is " + diagSum);

            int a = 0;

            for(int i = 0; i<3; i++)
            {
                a += array[i, i];
            };

            int b = 0;
            for(int i = 3; i>0; i--)
            {
                b += array[i,i-2]
            }

            Console.WriteLine(a);
            Console.ReadLine();


        }
    }
}
