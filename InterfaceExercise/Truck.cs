using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {

        }
        public bool Airbags { get; set; }
        public bool Brakes { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string CompanyName { get; set; }
        public string HomeLocation { get; set; }
        public bool TruckBed { get; set; }
        public bool TailGate { get; set; }

    }
}
