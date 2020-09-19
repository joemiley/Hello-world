using System;

namespace BooleanSelection_2017_Sem12
{
    class MainClass
    {
        public static void Main()
        {
            // variables
            double mark;
            char grade;

            /**
             * Note:
             *  \ - the forward slash is also known as the Escape operator
             *      it can be used with string and char data types to Escape certain characters
             *      such as: ' (single quote - \'), " (double quote - \"), \ (the slash character - \\)
             *      OR it can be used to form certain special characters, such as:
             *      \n (newline character), \t (tab character - think Office Word), etc.
             *      there are others, will leave you to discover :)
             */ 

            // get mark from user
            Console.WriteLine("Please enter the student's Mark: (format: Decimal number)");
            mark = Convert.ToDouble(Console.ReadLine());

            /**
             * First, do the Math
             */ 

            if (((mark > 100) || (mark < 0)) /*&& (1 == 1)*/)
            { // too high

                grade = 'X';

            }
            else if (mark >= 70)
            { // A

                grade = 'A';

            }
            else if (mark >= 60)
            { // B

                grade = 'B';

            }
            else if (mark >= 50)
            { // C

                grade = 'C';

            }
            else if (mark >= 40)
            { // D

                grade = 'D';

            }
            else if (mark >= 30)
            { // E

                grade = 'E';

            }
            else
            { // F

                grade = 'F';

            }

            /**
             * Then, inform the user of the outcome
             */ 

            if (grade == 'X')
            {

                Console.WriteLine("Invalid mark.");

            }
            else
            {

                Console.WriteLine("Grade: {0}", grade);

            }


            Console.ReadKey();
        }
    }
}
