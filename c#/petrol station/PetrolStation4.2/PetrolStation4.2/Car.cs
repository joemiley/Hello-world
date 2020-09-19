using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation4._2
{
    public class Car : Vehicle
    {

        public Car(double FT, string NP, double C, double FD, string FTP) : base(FT, NP, C, FD)
        {
            fuelType = FTP;
        }
    }
    

    
}
