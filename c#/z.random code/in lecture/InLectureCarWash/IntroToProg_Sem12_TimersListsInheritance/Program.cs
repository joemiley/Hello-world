using System;
using System.Timers;
using System.Collections.Generic;

/**
 * Automated Valet Cleaning Service Demo App
 * - Classes: Vehicle (Abstract); Car (Vehicle); Van (Vehicle); Transactions
 * - Storage: Queue, Transactions
 * - Asynchronous Automation: Timers
 */

namespace IntroToProg_Sem12_TimersListsInheritance
{
    class MainClass
    {
        /// <summary>
        /// The random number generator.
        /// </summary>
        static Random rng = new Random();

        /// <summary>
        /// The Vehicle queue.
        /// </summary>
        static List<Vehicle> queue = new List<Vehicle>();

        /// <summary>
        /// The transactions list.
        /// </summary>
        static List<Transaction> transactions = new List<Transaction>();

        /// <summary>
        /// The queue timer.
        /// </summary>
        static Timer queueTimer = new Timer(2000); // every 2000 milliseconds
        /// <summary>
        /// The UI Timer.
        /// </summary>
        static Timer UITimer = new Timer(2050);
        /// <summary>
        /// The queue check timer.
        /// </summary>
        static Timer QueueCheckTimer = new Timer(1500);

        public static void Main(string[] args)
        {
            // start timers

            // get the timer to execute GenerateVehicle every 2 seconds (see above)
            queueTimer.Elapsed += GenerateVehicle;
            // repeat indefinitely
            queueTimer.AutoReset = true;
            // start timer
            queueTimer.Enabled = true;

            // get the timer to execute DrawUI every 2.05 seconds (see above)
            UITimer.Elapsed += DrawUI;
            // repeat indefinitely
            UITimer.AutoReset = true;
            // start timer
            UITimer.Enabled = true;

            // get the timer to execute CheckQueue every 1.5 seconds (see above)
            QueueCheckTimer.Elapsed += CheckQueue;
            // repeat indefinitely
            QueueCheckTimer.AutoReset = true;
            // start timer
            QueueCheckTimer.Enabled = true;

            // prevent the program from closing, as timers will not do that
            //Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Generates vehicles for the queue.
        /// </summary>
        /// <param name="source">Timer Source.</param>
        /// <param name="e">Timer event information.</param>
        public static void GenerateVehicle(Object source, ElapsedEventArgs e)
        {
            // local variables
            string registrationNumber;
            int cleanlinessLevel, backSeatSpace, storageSpace;

            int type = rng.Next(0, 2);
            Vehicle vehicle = null;

            switch (type)
            {
                case 0:
                    // create car
                    registrationNumber = "Raz" + rng.Next(1, 1000);
                    cleanlinessLevel = rng.Next(0, 11);
                    backSeatSpace = rng.Next(2, 4);

                    vehicle = new Car(registrationNumber, cleanlinessLevel, backSeatSpace);

                    break;

                case 1:
                    // create van
                    registrationNumber = "Raz" + rng.Next(1, 1000);
                    cleanlinessLevel = rng.Next(0, 11);
                    storageSpace = rng.Next(50, 101);

                    vehicle = new Van(registrationNumber, cleanlinessLevel, storageSpace);

                    break;
            }

            queue.Add(vehicle);
        }

        /// <summary>
        /// Checks the vehicle queue for waiting vehicles.
        /// </summary>
        /// <param name="source">Timer Source.</param>
        /// <param name="e">Timer event information.</param>
        public static void CheckQueue(Object source, ElapsedEventArgs e)
        {
            // while there are vehicles waiting in the queue
            while (queue.Count > 0)
            {
                // get the first vehicle
                Vehicle vehicle = queue[0];

                // remove it from queue
                queue.RemoveAt(0);

                // service it
                ServiceVehicle(vehicle);
            }
        }

        /// <summary>
        /// Services a vehicle.
        /// </summary>
        /// <param name="v">The vehicle.</param>
        public static void ServiceVehicle(Vehicle v)
        {
            Transaction transaction = new Transaction();

            transaction.Cost = Math.Round(rng.NextDouble() * 100, 2);
            transaction.Vehicle = v;

            transactions.Add(transaction);
        }

        /// <summary>
        /// Draws the user interface.
        /// </summary>
        /// <param name="source">Timer Source.</param>
        /// <param name="e">Timer event information.</param>
        public static void DrawUI(Object source, ElapsedEventArgs e)
        {
            Console.Clear();

            ShowVehicles();

            Console.WriteLine();
            Console.WriteLine();

            ShowTransactions();
        }

        /// <summary>
        /// Shows the vehicles queue.
        /// </summary>
        public static void ShowVehicles()
        {
            Console.WriteLine("Queue: ");

            //for (int i = 0; i < queue.Count; i++)
            //{
            //    Console.Write("Type: {0} | ", queue[i].GetType().Name);

            //    Console.Write("PN: {0} | ", queue[i].PlateNumber);
            //    Console.Write("CL: {0} | ", queue[i].CleanlinessLevel);

            //    if (queue[i].GetType().Name == "Car")
            //    {
            //        Console.Write("BSC: {0}", ((Car)queue[i]).BackSeatsCount);
            //    }

            //    if (queue[i].GetType().Name == "Van")
            //    {
            //        Console.Write("SS: {0}", ((Van)queue[i]).StorageSpace);
            //    }

            //    Console.WriteLine();
            //}

            // another way of going through a list if you don't care about the index
            queue.ForEach((Vehicle vehicle) =>
            // vehicle will be a local variable inside this {} code block
            {

                // get the vehicle type
                string type = vehicle.GetType().Name;

                Console.Write("Type: {0} | ", type);
                Console.Write("PN: {0} | ", vehicle.PlateNumber);
                Console.Write("CL: {0} | ", vehicle.CleanlinessLevel);

                switch (type)
                {
                    case "Car":
                        Console.Write("BSC: {0}", ((Car)vehicle).BackSeatsCount);
                        break;
                    case "Van":
                        Console.Write("SS: {0}", ((Van)vehicle).StorageSpace);
                        break;
                }

                Console.WriteLine();
            });

        }

        /// <summary>
        /// Shows the transactions list.
        /// </summary>
        public static void ShowTransactions()
        {
            // generally start at the end
            int stopAtIndex = 0;

            // if there are more than 5, stop towards the end
            if (transactions.Count > 5)
            {
                stopAtIndex = transactions.Count - 5;
            }

            for (int i = transactions.Count - 1; i >= stopAtIndex; i--)
            {
                Console.Write("Transaction Cost: {0} | ", transactions[i].Cost);
                Console.Write("Transaction Vehicle PN: {0} | ", transactions[i].Vehicle.PlateNumber);
                Console.WriteLine();
            }
        }
    }
}
