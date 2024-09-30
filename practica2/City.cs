using System;
using Practice2;

namespace Practice2
{
    internal class City
    {
        private string cityName;
        public List<Taxi> TaxiCarsList { get; private set; }
        public List<PoliceStation> PoliceStationList { get; private set; }

        public City(string cityName)
        {
            this.cityName = cityName;
            TaxiCarsList = new List<Taxi>();
            PoliceStationList = new List<PoliceStation>();

        }
        public string CityName()
        {
            return cityName;
        }
        public void RegisterTaxiCar(Taxi taxiCar)
        {
            if (!TaxiCarsList.Contains(taxiCar))
            {

                TaxiCarsList.Add(taxiCar);
                taxiCar.RegisterTaxiToCity(this);

            }
            else
            {
                Console.WriteLine(taxiCar.WriteMessage($"Already registered to {CityName} "));

            }


            //policeCar.WriteMessage($"Regestered to Police Station {city}");

        }



        public void RemoveTaxiCar(Taxi taxicar)
        {

            if (TaxiCarsList.Contains(taxicar))
            {
                // eliminate taxi from registered taxis 
                TaxiCarsList.Remove(taxicar);
                // turn city in taxi to null (does not have a license)
                taxicar.RemoveCity();

            }
            else
            {
                Console.WriteLine($"Taxi not found in registered taxis in {CityName}");
            }
        }

        public void RegisterPoliceStation(PoliceStation policeStation)
        {
            if (!PoliceStationList.Contains(policeStation))
            {

                PoliceStationList.Add(policeStation);
                policeStation.SetCity(this);

            }
            else
            {
                Console.WriteLine(($"This police station is already registered to {CityName}"));

            }


            //policeCar.WriteMessage($"Regestered to Police Station {city}");

        }
    }
}