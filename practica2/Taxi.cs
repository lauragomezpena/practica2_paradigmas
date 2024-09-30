using System;
using Practice2;
namespace Practice2
{
    class Taxi : Vehicle
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances.
        private static string typeOfVehicle = "Taxi";
        private bool isCarryingPassengers;
        private City? city;
        public Taxi(string plate) : base(typeOfVehicle, plate)
        {
            //Values of atributes are set just when the instance is done if not needed before.
            isCarryingPassengers = false;
            SetSpeed(45.0f);
        }

        public void StartRide()
        {
            if (!isCarryingPassengers)
            {
                isCarryingPassengers = true;
                SetSpeed(100.0f);
                Console.WriteLine(WriteMessage("starts a ride."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already in a ride."));
            }
        }

        public void StopRide()
        {
            if (isCarryingPassengers)
            {
                isCarryingPassengers = false;
                SetSpeed(45.0f);
                Console.WriteLine(WriteMessage("finishes ride."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is not on a ride."));
            }
        }

        public void RegisterTaxiToCity(City registerd_city)
        {
            city = registerd_city;
            Console.WriteLine(WriteMessage($"Registered in city {city.CityName()}"));

        }

        public void RemoveCity()
        {
            if (city != null)
            {
                Console.WriteLine(WriteMessage($"License removed from {city.CityName()}."));
                city = null;
            }


        }
    }
}
