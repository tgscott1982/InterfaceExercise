using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {

        }
            
        public bool Airbags { get; set; }
        public bool Brakes { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string CompanyName { get; set; }
        public string HomeLocation { get; set; }
        public bool LuggageRack { get; set; }
        public bool TrailerHitch { get; set; }

    }
}
