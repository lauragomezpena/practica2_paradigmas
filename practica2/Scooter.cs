using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    internal class Scooter: UnregisteredVehicle
    {
        private static string typeOfVehicle = "Scooter";
        public Scooter() : base(typeOfVehicle)
        {
            
            SetSpeed(45.0f);
        }
    }
}
