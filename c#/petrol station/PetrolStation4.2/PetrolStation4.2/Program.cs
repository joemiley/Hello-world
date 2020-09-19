using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//enabling us to use timers in our code
using System.Timers;

namespace PetrolStation4._2
{
    class Program
    {
        //build a random number generator to call on in the code
        static Random rng = new Random();

        //build a global int to hold how many Vehicles that have been fueled
        static double commission= 0;
        static double litres = 0;
        static int totalFueled = 0;
        static int totalNumberOfTransations = 0;

        //lists=arrays that replace themselves with a new array+1 posistion
        //lists also if posistion 0 is removed then all variables loaded will
        //shift up one persistion to close the space.

        //create a list of queued vehicles before they move to a pump
        static List<Vehicle> queueOfVehicles = new List<Vehicle>();

        //create a list of pumps to take the Vehicles into after the queue list
        //once it is coppied from the first posistion in queue it will need
        //to go to a pump which is free (pumps 1-9)
        static List<Pump> Pumps = new List<Pump>();

        //once a vehicle leaves a pump add new vehicle to the finished vehicle from the pump
        static List<Vehicle> finishedVehicle = new List<Vehicle>();

        //create a list for missed vehicles
        static List<Vehicle> missedVehicles = new List<Vehicle>();

        //create a timer for the display
        static Timer timer_Display = new Timer(2000);

        //car spawns every 1.5 seconds (to be randomized later)
        static Timer timer_vehicleSpawn = new Timer(rng.Next(1500, 2200));

        static void Main(string[] args)
        {
            //create 9 pump classes using a for loop
            //for loop to tick through till it gets to 8 (9 posistions)
            for (int i = 0; i < 9; i++)
            {
                //each tick it adds a new pump to the "Pumps" list
                Pumps.Add(new Pump());
            }

            //logic: 
            //1.pumps and display start
            //2.Vehicle gets spawned into the queue
            //3.Vehicle goes from queue to a pump
            //4.transaction recorded (price, pump, numberPlate, vehicle type etc)
            //5.Vehicle gets removed/leaves/wrote over

            //enable all timers when the program starts
            //using bool logic 
            timer_Display.Enabled = true;
            timer_vehicleSpawn.Enabled = true;
            
            //auto reset all timers when the time ends
            timer_Display.AutoReset = true;
            timer_vehicleSpawn.AutoReset = true;
            
            //what happeneds in the methods when the timer ends
            //naming the method which is called
            timer_Display.Elapsed += Display;
            timer_vehicleSpawn.Elapsed += vehicleSpawn;
            
            //now something to stop the console from closing until needed
            Console.ReadKey();
        }

        //calling the display timer
        public static void Display (object source, ElapsedEventArgs e)
        {
            //so it changes with each tick
            Console.Clear();

            //use the fueling method to show the Vehicles form
            //queueOfVehicles into the pumps when they are free
            showFueling();
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //show total number of vehicles finished fueling
            //using the int "totalFueled" which starts at 0 
            //and adds one each time a Vehicle finishes                          uses the commission global veriable         this then gets the 1% to two decimal places
            Console.WriteLine("Total Vehicles Fueled: " +totalFueled+ "          grand total: £"+ commission + "          Commission(1%): £" + Math.Round(commission*0.01,2));
            Console.WriteLine();

            //use the global int thats updated                                   litres global varialbe to output on the display        Adding the commission to the hourly rate*8 hours(2.49per hour)           
            Console.Write("Total Transactions: "+ totalNumberOfTransations + "             litres total: " + litres + "L"+ "             shift cost: £"+ Math.Round(commission*0.01+2.49*8,2));

            Console.WriteLine();
            Console.WriteLine();

            //show the list of queueOfVehicles(0-4)
            displayVehiclesInQueue();

            Console.WriteLine();

            //showing transactions as "Cost" in the vehicle class
            ShowTransactions(); 
        }
        
        //method to create a vehicle with attributes 
        public static void vehicleSpawn(object source, ElapsedEventArgs e)
        {
            //creating a numberPlate
            string numberPlate;
            string fuelType = "";
            //creating a fuelTime number (under a quater for each vehicle)
            //car<10l van<20l HGV<30l

            double fuelTime;
            double fuelDisplensed;
            double Cost;
            int fuelTypeRNG;

            //to show the type of vehicle
            int type = rng.Next(0, 3);

            //using a method to return a value
            int firstFreePump = findPump();

            if (queueOfVehicles.Count < 6)
            {
                //create a new vehicle
                Vehicle vehicle = null;

                switch (type)
                {
                    case 0:
                        //number plate of "car...."
                        numberPlate = "car" + rng.Next(1000, 9999);
                        //create an int for the current fuel of the car of less than a
                        //quarter tank
                        //this is for a car and pump pumping at 1.5l per second
                        fuelTime = Math.Round((40 - rng.Next(1, 10)) / 1.5, 0);
                        Cost = Math.Round(fuelTime * 1.5 * 1.2, 2);
                        fuelDisplensed = fuelTime * 1.5;
                        fuelTypeRNG = rng.Next(0, 1);
                        if (fuelTypeRNG == 0) { fuelType = "Petrol"; }
                        else if (fuelTypeRNG == 1) { fuelType = "Diesel"; }
                        //create the vehicle instance with the stats above
                        vehicle = new Car(fuelTime, numberPlate, Cost, fuelDisplensed, fuelType);
                        break;

                    case 1:
                        //number plate of "van...."
                        numberPlate = "van" + rng.Next(1000, 9999);
                        //create an int for the current fuel of the car of less than a
                        //quarter tank
                        //this is for a van and pump pumping at 1.5l per second
                        fuelTime = Math.Round((80 - rng.Next(1, 20)) / 1.5, 0);
                        Cost = Math.Round(fuelTime * 1.5 * 1.2, 2);
                        fuelDisplensed = fuelTime * 1.5;
                        fuelTypeRNG = rng.Next(0, 2);
                        if (fuelTypeRNG == 0) { fuelType = "Petrol"; }
                        else if (fuelTypeRNG == 1) { fuelType = "Diesel"; }
                        else if (fuelTypeRNG == 2) { fuelType = "LPG"; }
                        //create the vehicle instance with the stats above
                        vehicle = new Van(fuelTime, numberPlate, Cost, fuelDisplensed, fuelType);
                        break;

                    case 2:
                        //number plate of "HGV...."
                        numberPlate = "HGV" + rng.Next(1000, 9999);
                        //create an int for the current fuel of the car of less than a
                        //quarter tank
                        //this is for a HGV and pump pumping at 1.5l per second
                        fuelTime = Math.Round((120 - rng.Next(1, 40)) / 1.5, 0);
                        Cost = Math.Round(fuelTime * 1.5 * 1.2, 2);
                        fuelDisplensed = fuelTime * 1.5;
                        fuelTypeRNG = rng.Next(0, 1);
                        if (fuelTypeRNG == 0) { fuelType = "Diesel"; }
                        else if (fuelTypeRNG == 1) { fuelType = "LPG"; }
                        //create the vehicle instance with the stats above
                        vehicle = new HGV(fuelTime, numberPlate, Cost, fuelDisplensed, fuelType);
                        break;
                }

                //make queueOfVehicles only five long
                if (queueOfVehicles.Count < 5)
                {
                    //add the newly created vehicle to queueOfVehicles
                    queueOfVehicles.Add(vehicle);
                }
                //add the sixth vehicle to the missedVehicle list so the queue stays at five
                else
                {
                    if (missedVehicles.Count < 5)
                    {
                        missedVehicles.Add(vehicle);
                    }

                    //make the list dynamic so it only shows 5 vehicles at a time
                    //taking the oldest one away
                    else
                    {

                        missedVehicles.RemoveAt(0);
                    }
                }
            }

            //if statement to check for the first free pump by looking 
            //to see the value (if not -1 then pump is free)
            if (firstFreePump != -1)
            {
                //save the pump number inside the vehicle class
                queueOfVehicles[0].pumpNumber = firstFreePump;

                //gets the first free pump and takes the values for the
                //vehicle at posistion 0 of queueOfVehicles list
                Pumps[firstFreePump].takeVehicle(queueOfVehicles[0]);

                //now remove the 0 posistion vehicle from queueOfVehicles
                //making the other vehicles shift up one space
                queueOfVehicles.RemoveAt(0);
            }

            //check if a pump is finished using a method
            checkIfPumpIsFinished();
        }
       
        //method to display my list of queued vehicles
        public static void displayVehiclesInQueue()
        {
            //show title
            Console.WriteLine("Vehicle Queue: ");

            //for each vehicle we'll print out the type and number plate
            queueOfVehicles.ForEach((Vehicle vehicle) =>
            {
                //get the type of vehicle
                string type = vehicle.GetType().Name;

                //print the type
                Console.Write("type of vehicle: " + type + " |");

                //print the numberPlate
                Console.Write("Numberplate: " + vehicle.numberPlate + " |");
                Console.WriteLine();
            });
        }

        //method to find a pump that is free
        public static int findPump()
        {
            //create a for loop to go through each pump
            for(int i = 0; i < Pumps.Count; i++)
            {
                //check to see if the pump is actually free by using the 
                //isfree method in pumps class
                if (Pumps[i].isFree() == true)
                {
                    //returns the number of the pump that is free
                    return i;
                }

            }

            //if none are free then return -1 to close them off
            return -1;
        }

        //method to place the cars into the fueling posistion
        public static void showFueling()
        {
            //title
            Console.WriteLine("Vehicles being fueled: ");
            Console.WriteLine();

            //a for loop that goes through each pump in the "Pump" list
            for (int i = 0; i < Pumps.Count; i++)
            {
                //showing pump posistion i
                Console.Write("Pump " + (i+1) + ":");

                //use the outPutDisplay method in the pump class
                //(//if vehcile is not null then show the numberplate)
                Pumps[i].outPutDisplay();
                Console.Write("       ");
                
                //get pump 1,2,3 on one line (postistion 0,1,2 respectively)
                //then add two lines before 4,5,6
                if (i == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
                //then at posistion 5 (pump 6) add two more empty lines
                if (i == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }

                //this gives us the format of 
                /* 1 2 3
                 * 4 5 6
                 * 7 8 9*/
            }

        }

        //method to check if the pump is free or not
        public static void checkIfPumpIsFinished()
        {
            //for every pump in our list of pumps
            foreach (Pump p in Pumps)
            {
                //if the pump is finished (p.finished) then...
                if(p.finished == true)
                {
                    //add one to totalFueled
                    totalFueled++;
                    //add one to the finished vehicle list
                    finishedVehicle.Add(p.prev_V);
                    //add the value to commission value (total taken before dividing happens)
                    commission += finishedVehicle[finishedVehicle.Count - 1].Cost;
                    //add the litres to the total liters amount
                    litres += finishedVehicle[finishedVehicle.Count - 1].fuelTime*1.5;
                    //reset the pump to have nothing in it
                    p.prev_V = null;
                    //add one to the total transactions
                    totalNumberOfTransations++;
                    //set pump p's logic to false so that the class
                    //method of finished fueling can turn it to true
                    //when the vehicle is done
                    p.finished = false;
                }
            }
        }

        //this method shows numberplate, fueling time and and cost of the transaction for each
        //Vehicle in the finishedVehicle list
        public static void ShowTransactions()
        {
            //title
            Console.WriteLine("Missed vehicles due to queue being to long:");
            //show the list of vehicles in missedVehicles list and print them one by one as they come
            for (int i = 0; i < missedVehicles.Count; i++)
            {

                Console.WriteLine("Vehicle type: " + missedVehicles[i].GetType().Name + "| " + "platenumber: " + missedVehicles[i].numberPlate + "| ");

            }
            Console.WriteLine();

            //title
            Console.WriteLine("Transactions complete:");
            //show the list of vehicles in finishedVehicle list and print them one by one as they come
            for (int i = 0; i < finishedVehicle.Count; i++)
            {
              
                Console.WriteLine("plate number: " + finishedVehicle[i].numberPlate + "| "+"Fuel Type: "+ finishedVehicle[i].fuelType+"| " + "fuelTime: " + finishedVehicle[i].fuelTime + "| "+ "payment: " + finishedVehicle[i].Cost + "|" + "Litres dispensed:"+ finishedVehicle[i].fuelDisplensed + "L" + " |" + "Pump Number: "+ (finishedVehicle[i].pumpNumber+1) );
                
            }
            Console.WriteLine();
        }
    }
}
