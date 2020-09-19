using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation4._2
{
    //going to be an abstract class
    public abstract class Vehicle
    {
        //getting the value for numberplate from main then setting
        // it a specific instance of "Vehicle"
        public string numberPlate { get; set; }

        //getting the value for fuelCapacity form main and setting
        //it to this instance of "vehicle"
        public double fuelTime { get; set; }

        public double Cost { get; set; }

        public double fuelDisplensed { get; set; }

        public int pumpNumber { get; set; }

        public string fuelType { get; set; }

        //setting the variables for the class (constructor)
        public Vehicle(double FT, string NP, double C,double FD)
        {
            fuelTime = FT;
            numberPlate = NP;
            Cost = C;
            fuelDisplensed = FD;
        }

    }
}
