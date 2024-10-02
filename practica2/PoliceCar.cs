using Microsoft.VisualBasic.FileIO;
using practica2;
using Practice2;

namespace Practice2
{
    class PoliceCar : RegisteredVehicle
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car";
        private bool isPatrolling;
        private bool chasing;
        private string? taxiPlate;
        private SpeedRadar? speedRadar;
        private PoliceStation? policeStation;

        public PoliceCar(string plate) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;

        }

        public void UseRadar(Vehicle vehicle)
        {
            if (speedRadar != null) 
            {
                if (isPatrolling)
                { 
                    speedRadar.TriggerRadar(vehicle);
                    var result = speedRadar.GetLastReading();
                    Console.WriteLine(WriteMessage($"Triggered radar. Result: {result.Item2}"));

                    if (policeStation != null)
                    {
                        if (result.Item1) //driving illegally 
                        {
                            policeStation.ActivateAlarm(vehicle.GetPlate());
                                
                        }
                    }
                }
                else
                    Console.WriteLine(WriteMessage($"is not patrolling, can not use radar."));

            }
            else
            {
                   Console.WriteLine(WriteMessage($"has no active radar."));

            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }


        public bool Chasing()
        {
            return chasing;
        }

        public void StartChasing()
        {
            chasing = true;
            Console.WriteLine(WriteMessage("started chasing"));


        }

        public void SetTaxiPlate(string plate)
        {

            taxiPlate = plate; 
        }

        public void SetStation(PoliceStation station)
        {
            policeStation = station;
            Console.WriteLine(WriteMessage($"Registered to Police Station {policeStation.StationName}"));
        }
        public void PrintRadarHistory()

        {

            if (speedRadar != null)
            {
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }

            }
            else
            {
                Console.WriteLine(WriteMessage("No history available: no active radar"));

            }
        }
        public void SetRadar(SpeedRadar radar)
        {
            speedRadar = radar;
            Console.WriteLine(WriteMessage("Speed Radar Created"));


        }


    }
}
