using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice2;

namespace practica2
{
    abstract class RegisteredVehicle: Vehicle
    {
        private string plate;
        public RegisteredVehicle(string typeOfVehicle , string plate) : base(typeOfVehicle)
        {

            this.plate = plate; 
        }


        public override string GetPlate()
        {
            return plate;
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetPlate()}";

        }
    }
}
