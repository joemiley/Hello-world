using System;

namespace Assignment_2_PetrolStation
{
    class Vehicle
    {
        public string fuelType;
        public double fuelTime;
		public static int nextCarID = 0;
		public int carID;
        public Vehicle(string ftp, double ftm)
        {
            fuelType = ftp;
            fuelTime = ftm;
			carID = nextCarID++;
        }
    }
}
