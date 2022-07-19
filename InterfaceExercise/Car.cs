using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }
        public bool Airbags { get; set; }
        public bool Brakes { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string CompanyName { get; set; }
        public string HomeLocation { get; set; }
        public bool BackSeat { get; set; }
        public bool Trunk { get; set; }

    }
}
