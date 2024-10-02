using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice2;

namespace practica2
{
    abstract class UnregisteredVehicle:Vehicle
    {
        

            public UnregisteredVehicle(string typeOfVehicle) : base(typeOfVehicle)
            {


            }


        public override string GetPlate()
        {
            return "Vehicle has no plate";
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()}";
        }
    }
}
