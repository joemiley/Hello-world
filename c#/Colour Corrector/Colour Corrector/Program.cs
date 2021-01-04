using System;

namespace Colour_Corrector
{
    class Program
    {
        static void Main(string[] args)
        {
            //catching all the inputs from each pixel and setting them to their closest value
            int rZero = 0;

            int rQuarter = 64;

            int rhalf = 128;

            int rThreeQuarters = 192;

            int Full = 255;


            string redInputstr;
            string blueInputstr;
            string greenInputstr;

            // to test i'll input the rgb values and have it output the most relivent ones
            Console.WriteLine("what is the red value");
            redInputstr=Console.ReadLine();

            Console.WriteLine("what is the green value");
            greenInputstr = Console.ReadLine();

            Console.WriteLine("what is the blue value");
            blueInputstr = Console.ReadLine();

            // try parsing the inputs to an in
            double redInput;
            double.TryParse(redInputstr, out redInput);

            if(redInput <= 0)
            {
                redInput=1;
            }

            Console.WriteLine(redInput);

            double blueInput;
            double.TryParse(blueInputstr, out blueInput);

            if (blueInput <= 0)
            {
                blueInput=1;
            }

            Console.WriteLine(blueInput);

            double greenInput;
            double.TryParse(greenInputstr, out greenInput);

            if (greenInput <= 0)
            {
                greenInput=1;
            }

            Console.WriteLine(greenInput);


            // do the calculations needed
            double redOutPut = 100/255;
            double greenOutPut = (100/255)*greenInput;
            double blueOutPut = (100/255)*blueInput;

            Console.WriteLine("the colour values needed are:");
            Console.WriteLine("r:"+ redOutPut);
            Console.WriteLine("g:" + greenOutPut);
            Console.WriteLine("b:" + blueOutPut);
            Console.ReadLine();


        }
    }
}
