namespace Practice2
{
    abstract class Vehicle : IMessageWritter
    {
        private string typeOfVehicle;
        //private string plate;
        private float speed;

        public Vehicle(string typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
            //this.plate = plate;
            speed = 0f;
        }

        //Override ToString() method with class information
        public override string ToString()
        {
            // return $"{GetTypeOfVehicle()} with plate {GetPlate()}";
            return $"{GetTypeOfVehicle()}";
        }


        public string GetTypeOfVehicle()
        {
            return typeOfVehicle;
        }



        public float GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }



        //Implment interface with Vechicle message structure
        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }

        public abstract string GetPlate();
       
    }
}
