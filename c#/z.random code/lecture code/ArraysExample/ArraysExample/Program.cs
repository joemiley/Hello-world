using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExample
{   //student management program
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            string[] names;
            int[] marksFoD;
            int noOfStudents;

            //read the noOfStudents variable
            Console.Write("Enter the number of students: ");
            noOfStudents = Convert.ToInt32(Console.ReadLine());

            //allocate memory for the arrays
            names = new string[noOfStudents];
            marksFoD = new int[noOfStudents];

            // assign values to the names array
            for( int ind = 0; ind < noOfStudents; ind++)
            {
                //read the name
                Console.Write("student" + ind + " name = ");
                names[ind] = Console.ReadLine();

                //read the mark
                Console.Write("student" + ind + " mark = ");
                marksFoD[ind] = Convert.ToInt32(Console.ReadLine());
            }

            for (int ind = 0; ind < noOfStudents; ind++)
            {
                Console.WriteLine(names[ind] + " got the mark " + marksFoD[ind]);
            }

            Console.ReadLine();
        }
    }
}
