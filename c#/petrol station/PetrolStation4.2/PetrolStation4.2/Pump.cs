using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//pumps need a timer for fueling duration
using System.Timers;

namespace PetrolStation4._2
{
    class Pump
    {
        //time it takes to fuel
        

        //naming the vehicle that is being used
        Vehicle v;

        public Vehicle prev_V { get; set; }

        //naming the timer
        Timer fueler;

        //either gets true or false 
        //or sets true or false
        public bool finished { get; set; }


        public void takeVehicle(Vehicle _v)
        {
            //showing vehicle as _V
            v = _v;

            //creating a new timer
            fueler = new Timer();

            //starting the timer
            fueler.Enabled = true;

            //this is to vary the amount of timer dependent of capacity
            fueler.Interval = v.fuelTime * 1000;

            //running it only once per instance
            fueler.AutoReset = false;

            //creating the method for what the timer actually does
            fueler.Elapsed += finishedFueling;
        }

        //to output true when there is no vehicle
        public void finishedFueling(object source, ElapsedEventArgs e)
        {
            //grabbing the vehicles details to use in the finishedVehicle list
            //also adding the values to the commision 
            prev_V = v;
            //if no vehicle then finished is equal to true
            v = null;
            finished = true;
        }

        //method of a display method where v (vehicle) is not nothing (null)
        //then print out the vehicles numberPlate.
        public void outPutDisplay()
        {
            //if vehcile is not null then show the numberplate
            if(v != null)
            {
                Console.Write(v.numberPlate);
            }
        }

        //boolean logic to show if a pump is free or not
        public bool isFree()
        {
            return v == null;
        }
    }
}
