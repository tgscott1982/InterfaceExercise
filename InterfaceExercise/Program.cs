using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var car1 = new Car()
            {
                Airbags = true,
                BackSeat = true,
                Brakes = true,
                Trunk = true,
                CompanyName = "Papa Honda",
                HomeLocation = "Minnesota",
                Make = "Honda",
                Model = "Civic"
            };

            var truck1 = new Truck()
            {
                Airbags = true,
                Brakes = true,
                TailGate = true,
                TruckBed = true,
                CompanyName = "OG Chevy",
                HomeLocation = "California",
                Make = "Chevy",
                Model = "Silverado"
            };

            var suv1 = new SUV()
            {
                Airbags = true,
                Brakes = true,
                LuggageRack = true,
                TrailerHitch = true,
                CompanyName = "Uncle Toyota",
                HomeLocation = "Florida",
                Make = "Toyota",
                Model = "RAV4"
            };

            var vehicleList = new List<IVehicle>();

            vehicleList.Add(car1);
            vehicleList.Add(truck1);
            vehicleList.Add(suv1);

            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine($"Company Make: {vehicle.Make}");
                Console.WriteLine($"Company Model: {vehicle.Model}");
                Console.WriteLine($"Airbag check: {vehicle.Airbags}");
                Console.WriteLine($"Brake check: {vehicle.Brakes}\n");
            }


        }
    }
}
