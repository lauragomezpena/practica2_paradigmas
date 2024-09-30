using Practice2;

namespace Practice2
{
    class SpeedRadar : IMessageWritter
    {
        //Radar doesn't know about Vechicles, just speed and plates
        private string plate;
        private float speed;
        private float legalSpeed = 50.0f;
        public List<float> SpeedHistory { get; private set; }

        public SpeedRadar()
        {
            plate = "";
            speed = 0f;
            SpeedHistory = new List<float>();
        }

        public void TriggerRadar(Vehicle vehicle)
        {
            plate = vehicle.GetPlate();
            speed = vehicle.GetSpeed();
            SpeedHistory.Add(speed);
        }

        public (bool, string) GetLastReading()
        {
            string message;
            bool result;

            if (speed > legalSpeed)
            {
                result = true;
                message = "Caught above legal speed.";
            }
            else
            {
                result = false;
                message = "Driving legally.";
            }

            return (result, WriteMessage(message));
        }


        public virtual string WriteMessage(string radarReading)
        {
            return $"Vehicle with plate {plate} at {speed.ToString()} km/h. {radarReading}";
        }
    }
}