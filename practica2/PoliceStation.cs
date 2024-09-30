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

        public List<PoliceCar> PoliceCarsList { get; private set; }

        private bool alarm { get; set; }

        private City? city;

        public PoliceStation()
        {
            alarm = false;
            PoliceCarsList = new List<PoliceCar>();

        }


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
                }


            }


        }

        public void RegisterPoliceCar(PoliceCar policeCar)
        {
            PoliceCarsList.Add(policeCar);
            policeCar.SetStation(this);
            //policeCar.WriteMessage($"Regestered to Police Station {city}");


        }

        public void SetCity(City registered_city)
        {
            city = registered_city;
            Console.WriteLine($"Police station registered to {city.CityName()}");
            //Console.WriteLine(WriteMessage($"Regestered to Police Station {station.City}"));
        }
    }
}
