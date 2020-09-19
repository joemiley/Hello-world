using System;
using System.Timers;

namespace Assignment_2_PetrolStation
{
    class Pump
    {
        public Vehicle currentVehicle = null;
        public string fuelType;

        public Pump(string ftp) {
            fuelType = ftp;
        }

        public bool IsAvailable() {
            // returns TRUE if currentVehicle is NULL, meaning available
            // returns FALSE if currentVehicle is NOT NULL, meaning busy
            return currentVehicle == null;
        }

        public void AssignVehicle(Vehicle v)
        {
            currentVehicle = v;

            Timer timer = new Timer();
            timer.Interval = v.fuelTime;
            timer.AutoReset = false; // don't repeat
            timer.Elapsed += ReleaseVehicle;
            timer.Enabled = true;
            timer.Start();
        }
        public void ReleaseVehicle(object sender, ElapsedEventArgs e)
        {
            currentVehicle = null;
            // record transaction
        }
    }
}
