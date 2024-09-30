using Practice2;

namespace Practice2
{
    class PoliceCar : Vehicle
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car";
        private bool isPatrolling;
        private bool chasing;
        private SpeedRadar speedRadar;
        private PoliceStation? policeStation;

        public PoliceCar(string plate) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            speedRadar = new SpeedRadar();

        }

        public void UseRadar(Vehicle vehicle)
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

        public void SetStation(PoliceStation station)
        {
            policeStation = station;
            Console.WriteLine(WriteMessage($"Regestered to Police Station"));
        }
        public void PrintRadarHistory()
        {
            Console.WriteLine(WriteMessage("Report radar speed history:"));
            foreach (float speed in speedRadar.SpeedHistory)
            {
                Console.WriteLine(speed);
            }
        }




    }
}
