using System.Collections.Generic;
using System.Timers;

namespace Assignment_2_PetrolStation
{
    class Data
    {
        private static Timer timer;
        public static List<Vehicle> vehicles;
        public static List<Pump> pumps;

        public static void Initialise() {
            InitialisePumps();
            InitialiseVehicles();
        }

        private static void InitialiseVehicles()
        {
            vehicles = new List<Vehicle>();

            // https://msdn.microsoft.com/en-us/library/system.timers.timer(v=vs.71).aspx
            timer = new Timer();
            timer.Interval = 1500;
            timer.AutoReset = true; // keep repeating every 1.5 seconds
            timer.Elapsed += CreateVehicle;
            timer.Enabled = true;
            timer.Start();
        }

        private static void CreateVehicle(object sender, ElapsedEventArgs e)
        {
			// queue limit
            // diesel, 10 second fuel time
            Vehicle v = new Vehicle("diesel", 10*1000);
            vehicles.Add(v);
        }
        private static void InitialisePumps()
        {
            pumps = new List<Pump>();

            Pump p;

            for (int i = 0; i < 9; i++)
            {
                p = new Pump("diesel");
                pumps.Add(p);
            }
        }
        public static void AssignVehicleToPump()
        {
            Vehicle v;
            Pump p;

            if (vehicles.Count == 0) { return; }

            for (int i = 0; i < 9; i++)
            {
                p = pumps[i];

                // note: needs more logic here, don't just assign to first
                // available pump, but check for the last available pump
                if (p.IsAvailable())
                {
                    v = vehicles[0]; // get first vehicle
                    vehicles.RemoveAt(0); // remove vehicles from queue
                    p.AssignVehicle(v); // assign it to the pump
                }

                if (vehicles.Count == 0) { break; }

            }
        }
    }
}
