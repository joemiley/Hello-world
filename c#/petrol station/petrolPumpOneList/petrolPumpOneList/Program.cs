using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace petrolPumpOneList
{
    class Program
    {
        static Random rng = new Random();

        static List<Vehicle> listOfVehicles = new List<Vehicle>();

        static Timer timerDisplay = new Timer(2000);
        static Timer timerVehicleSpawn = new Timer(rng.Next(1500, 2200));
         


        static void Main(string[] args)
        {

            timerDisplay.Enabled = true;
            timerVehicleSpawn.Enabled = true;

            timerDisplay.AutoReset = true;
            timerVehicleSpawn.AutoReset = true;

            timerDisplay.Elapsed += Display;
            timerVehicleSpawn.Elapsed += vehicleSpawn;

            //for(int i =0; i < 17; i++)
            //{

            //}

            Console.ReadKey();

        }

        public static void Display(object source, ElapsedEventArgs e)
        {
            Console.Clear();
            displayVehiclesInPumps();
            Console.WriteLine();
            Console.WriteLine();

        }

        public static void vehicleSpawn (object source, ElapsedEventArgs e)
        {

            string numberPlate;
            string fuelType="";
            double fuelTime;
            double fuelDisplensed;
            double Cost;
            int fuelTypeRNG;
            int pumpNumber;
            int[] usedPumps = new int[9];




         Vehicle vehicle = null;

            numberPlate = "vehicle" + rng.Next(1000, 9999);
            fuelTime = Math.Round((40 - rng.Next(1, 10)) / 1.5, 0);
            Cost = Math.Round(fuelTime * 1.5 * 1.2, 2);
            fuelDisplensed = fuelTime * 1.5;
            fuelTypeRNG = rng.Next(0, 2);
            if (fuelTypeRNG == 1)
            {
                fuelType = "petrol";
            }
            if (fuelTypeRNG == 0)
            {
                fuelType = "diesel";
            }
            if (listOfVehicles.Count == 0)
            {
                pumpNumber = rng.Next(1, 10);
            }

            else
            {
                for(int i = 0; i < listOfVehicles.Count; i++)
                {
                    do
                    {
                        pumpNumber = rng.Next(1, 10);
                    } while (usedPumps[i] == pumpNumber);
                    
                }
            }
          




            vehicle = new Vehicle(fuelTime, numberPlate, Cost, fuelDisplensed, fuelType, pumpNumber);

            listOfVehicles.Add(vehicle);


            //first 9 posistions are pumps
            //posistions 10-15 will be the queue
            //posistion 16 are missed vehicles
            if (listOfVehicles.Count > 18)
            {
                listOfVehicles.RemoveAt(0);
            }
        }

        public static void displayVehiclesInPumps()
        {
            
           
            Console.WriteLine("Cars At The Pumps");

            if(listOfVehicles.Count <= 9)
            {
                for (int i = 0; i < listOfVehicles.Count; i++)
                {

                    Console.Write(listOfVehicles[i].numberPlate + " | ");
                    Console.Write("pump Number " + listOfVehicles[i].pumpNumber + " | ");
                    Console.Write("fuel type " + listOfVehicles[i].fuelType + " | ");
                    Console.Write("fuel time " + listOfVehicles[i].fuelTime + " | ");
                    Console.Write("fuel dispensed " + listOfVehicles[i].fuelDisplensed + " | ");
                    Console.Write("cost " + listOfVehicles[i].Cost + " | ");
                    Console.WriteLine();

                }
            }

            if (listOfVehicles.Count <= 15 && listOfVehicles.Count >=10)
            {
                for (int i = 0; i < 9; i++)
                {

                    Console.Write(listOfVehicles[i].numberPlate + " | ");
                    Console.Write("pump Number " + listOfVehicles[i].pumpNumber + " | ");
                    Console.Write("fuel type " + listOfVehicles[i].fuelType + " | ");
                    Console.Write("fuel time " + listOfVehicles[i].fuelTime + " | ");
                    Console.Write("fuel dispensed " + listOfVehicles[i].fuelDisplensed + " | ");
                    Console.Write("cost " + listOfVehicles[i].Cost + " | ");
                    Console.WriteLine();

                }

                Console.WriteLine("vehicles Queing");

                for(int i=10;i<listOfVehicles.Count; i++)
                {
                    Console.Write(listOfVehicles[i].numberPlate + " | ");
                    Console.Write("pump Number " + listOfVehicles[i].pumpNumber + " | ");
                    Console.Write("fuel type " + listOfVehicles[i].fuelType + " | ");
                    Console.Write("fuel time " + listOfVehicles[i].fuelTime + " | ");
                    Console.Write("fuel dispensed " + listOfVehicles[i].fuelDisplensed + " | ");
                    Console.Write("cost " + listOfVehicles[i].Cost + " | ");
                    Console.WriteLine();
                }
            }

            if (listOfVehicles.Count > 15)
            {
                for (int i = 0; i < 9; i++)
                {

                    Console.Write(listOfVehicles[i].numberPlate + " | ");
                    Console.Write("pump Number " + listOfVehicles[i].pumpNumber + " | ");
                    Console.Write("fuel type " + listOfVehicles[i].fuelType + " | ");
                    Console.Write("fuel time " + listOfVehicles[i].fuelTime + " | ");
                    Console.Write("fuel dispensed " + listOfVehicles[i].fuelDisplensed + " | ");
                    Console.Write("cost " + listOfVehicles[i].Cost + " | ");
                    Console.WriteLine();

                }

                Console.WriteLine("vehicles Queing");

                for (int i = 10; i < 15; i++)
                {
                    Console.Write(listOfVehicles[i].numberPlate + " | ");
                    Console.Write("pump Number " + listOfVehicles[i].pumpNumber + " | ");
                    Console.Write("fuel type " + listOfVehicles[i].fuelType + " | ");
                    Console.Write("fuel time " + listOfVehicles[i].fuelTime + " | ");
                    Console.Write("fuel dispensed " + listOfVehicles[i].fuelDisplensed + " | ");
                    Console.Write("cost " + listOfVehicles[i].Cost + " | ");
                    Console.WriteLine();
                }

                Console.WriteLine("VehicleSpawn Missed");

                for(int i= 15; i < listOfVehicles.Count; i++)
                {
                    Console.Write(listOfVehicles[i].numberPlate + " | ");
                    Console.Write("pump Number " + listOfVehicles[i].pumpNumber + " | ");
                    Console.Write("fuel type " + listOfVehicles[i].fuelType + " | ");
                    Console.Write("fuel time " + listOfVehicles[i].fuelTime + " | ");
                    Console.Write("fuel dispensed " + listOfVehicles[i].fuelDisplensed + " | ");
                    Console.Write("cost " + listOfVehicles[i].Cost + " | ");
                    Console.WriteLine();
                }
            }
                
            

        }








    }
}
