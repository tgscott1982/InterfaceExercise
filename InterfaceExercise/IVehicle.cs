using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public bool Airbags { get; set; }
        public bool Brakes { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }


    }
}
