using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
           // int sunny = 34;
           // int cloudy = 31;
           // int lamp;

            int[] shirt = {6,7,3,5,6,5,2,1,3,4,5,9,0};

            for (int i = 0; i < shirt.Length; i++)
            {
                
                Console.WriteLine();
                Console.Write("position "+i+" = ");
                Console.Write(shirt[i]);



            }

            
            Console.ReadKey();


          






        }
    }
}
