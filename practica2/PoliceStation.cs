using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Practice2;

namespace Practice2
{
    internal class PoliceStation
    {
        private string stationName;

        public List<PoliceCar> PoliceCarsList { get; private set; }

        private bool alarm { get; set; }

        private City? city;

        public PoliceStation(string stationName)
        {
            alarm = false;
            PoliceCarsList = new List<PoliceCar>();
            this.stationName = stationName;   
        }

        public string StationName
        { get { return stationName; } } 
        public void ActivateAlarm(string plate)


        {
            alarm = true;

            foreach (PoliceCar car in PoliceCarsList)
            {
                if (car.IsPatrolling())
                {
                    Console.WriteLine("Alarm activated");
                    Console.WriteLine($"Police car {car.GetPlate()} notified of taxi {plate}");

                    car.StartChasing();
                    car.SetTaxiPlate(plate);    // Send the infractor plate to the plice car
                }


            }


        }

        public void RegisterPoliceCar(PoliceCar policeCar)
        {
            PoliceCarsList.Add(policeCar);
            policeCar.SetStation(this);



        }

        public void SetCity(City registered_city)
        {
            city = registered_city;
            Console.WriteLine($"Police station {stationName} registered to {city.CityName()}");

        }
    }
}
