using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace petrolPumpOneList
{
    public class Vehicle
    {
        ////this is going to hold the fueling time
        //Timer fueling;
        //Random RNG = new Random();

        //public void vehicleMain (Vehicle v)
        //{
        //    fueling = new Timer();
        //    fueling.Enabled = true;
        //    fueling.Interval = RNG.Next(18000,2200);
        //    fueling.AutoReset = false;
        //    fueling.Elapsed += fueler;
        //}

        //public static void fueler(object source, ElapsedEventArgs e)
        //{
        //    onOffArray[pumpNumber] = 0;
        //}

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
        public Vehicle(double FT, string NP, double C, double FD, string FTP, int PN)
        {
            fuelTime = FT;
            numberPlate = NP;
            Cost = C;
            fuelDisplensed = FD;
            fuelType = FTP;
            pumpNumber = PN;
        }


    }
}
