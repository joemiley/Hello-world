using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//enabling us to use timers in our code
using System.Timers;

namespace codingtestpractice
{
    class Program
    {

        static void Main(string[] args)
        {

            string userInput = "toned twos two onetwo one three";
            string one = "one";
            string two = "two";
            StringBuilder userInputStringBuilder = new StringBuilder(userInput);
            //Char [] userInputArray = userInput.ToCharArray();

            // tried stringbuilder
            // tried char array

            int checker = 0;

            for(int i = 0; i < userInputStringBuilder.Length; i++)
            {

                if (userInputStringBuilder[i] == ' ')
                {
                    if(userInputStringBuilder[i+4] == ' ')
                    {
                        for (int j = 0; j < one.Length; j++)
                        {
                            if (userInputStringBuilder[i + 1] == one[j])
                            {
                                userInputStringBuilder.Insert(i + 1, "!");
                                userInputStringBuilder.Insert(i + 5, "!");
                            }

                            if (userInputStringBuilder[i + 1] == two[j])
                            {
                                userInputStringBuilder.Insert(i + 1, "!");
                                userInputStringBuilder.Insert(i + 5, "!");
                            }
                        }

                    }

                }

            }
            Console.WriteLine(userInputStringBuilder);

        }
    }
}


