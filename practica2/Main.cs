using practica2;

namespace Practice2
{

    internal class MainClass
    {

        static void Main()
        {

            // Creación ciudad y estación de policia
            City city = new City("Madrid");
            PoliceStation station = new PoliceStation("Chamartin");
            Console.WriteLine(city.WriteMessage("Created"));
            Console.WriteLine(station.WriteMessage("Created"));
            city.RegisterPoliceStation(station);


            // Creación y registro en ciudad de taxis 
            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            Console.WriteLine(taxi1.WriteMessage("Created"));
            Console.WriteLine(taxi2.WriteMessage("Created"));
            city.RegisterTaxiCar(taxi1);
            city.RegisterTaxiCar(taxi2);


            // Creacion y registro de varios coches de policía (algunos con radar y otro sin radar)
            // PoliceCar 1 y 2 con radar, PoliceCar 3 sin radar
            SpeedRadar radar = new SpeedRadar();
            SpeedRadar radar2 = new SpeedRadar();

            PoliceCar policeCar1 = new PoliceCar("0001 CNP");
            PoliceCar policeCar2 = new PoliceCar("0002 CNP");
            PoliceCar policeCar3 = new PoliceCar("0003 CNP");
            Console.WriteLine(policeCar1.WriteMessage("Created"));
            Console.WriteLine(policeCar2.WriteMessage("Created"));
            Console.WriteLine(policeCar3.WriteMessage("Created"));
            policeCar1.SetRadar(radar);
            policeCar2.SetRadar(radar2);
            station.RegisterPoliceCar(policeCar1);
            station.RegisterPoliceCar(policeCar2);
            station.RegisterPoliceCar(policeCar3);
            Console.WriteLine("\n");

            // Intentar utilizar radar en coche de policia que no tiene radar 
            policeCar3.UseRadar(taxi1);
            Console.WriteLine("\n");

            // Alerta a la comisaría de comenzar a perseguir un vehículo con cierta matrícula
            taxi1.StartRide();
            policeCar1.StartPatrolling();
            policeCar3.StartPatrolling();
            policeCar1.UseRadar(taxi1);
            Console.WriteLine("\n");


            // Quitar la licencia a alguno de los taxis que haya sobrepasado la velocidad legal
            taxi1.StopRide();
            city.RemoveTaxiCar(taxi1);
            Console.WriteLine("\n");


        }
    }
}





