using System;
using System.Collections.Generic;

namespace IntroToProg_20178_Sem2_Inheritance
{
    class Vehicle {
        public int numberOfWheels;
        public float topSpeed;
        public float currentSpeed;

        public void Accelerate(){
            currentSpeed++;
            Console.WriteLine("Accelerating! currentSpeed = {0}", currentSpeed);
        }

        public void Break() {
            currentSpeed--;
            Console.WriteLine("Braking! currentSpeed = {0}", currentSpeed);
        }
    }

    class Bike : Vehicle
    {
        public string handleBarStyle;
    }

    class Car : Vehicle 
    {
        public int doors;
        public float engineSize;
    }

    class MainClass
    {
        public static List<Vehicle> myVehicles = new List<Vehicle>();

        public static void Main(string[] args)
        {

            //Vehicle veh;

            //veh = new Bike();
            //veh.currentSpeed = 0;
            //veh.numberOfWheels = 2;
            //veh.topSpeed = 20.5f;

            //Bike bike = (Bike)veh;
            //bike.handleBarStyle = "Red";

            Bike bike = new Bike();
            bike.currentSpeed = 0;
            bike.numberOfWheels = 2;
            bike.topSpeed = 20.5f;
            bike.handleBarStyle = "Red";

            Vehicle veh = bike;

            myVehicles.Add(veh);
            //myVehicles.Add(bike);

            Car car = new Car();
            car.currentSpeed = 0;
            car.numberOfWheels = 4;
            car.topSpeed = 200f;
            car.doors = 4;
            car.engineSize = 2.0f;

            veh = car;

            myVehicles.Add(veh);
            //myVehicles.Add(car);

            for (var i = 0; i < myVehicles.Count; i++) {

                Console.WriteLine("New Vehicle Loop: ");
                
                Vehicle v = myVehicles[i];

                Console.WriteLine("Vehicle: TopSpeed {0}", v.topSpeed);
                Console.WriteLine("Vehicle: NumberOfWheels {0}", v.numberOfWheels);

                //for (var j = 0; j < 100; j++)
                //{
                //    v.Accelerate();
                //}

                try {
                    
                    Bike b = (Bike)v;

                    Console.WriteLine("Bike: HandleBarStyle {0}", b.handleBarStyle);

                } catch (Exception e) {
                    //Console.WriteLine(e.Message);
                }

                try
                {
                    Car c = (Car)v;

                    Console.WriteLine("Car: Doors {0}", c.doors);
                    Console.WriteLine("Car: EngineSize {0}", c.engineSize);

                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                }
            }

            for (var i = 0; i < myVehicles.Count; i++)
            {
                Vehicle v = myVehicles[i];

                //for (var j = 0; j < 100; j++)
                //{
                //    v.Break();
                //}
            }

        }
    }
}
