namespace BuilderPattern
{
    /// <summary>
    ///  The 'ConcreteBuilder' class
    /// </summary>
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            Vehicle = new Vehicle("Car");
        }

        public override VehicleBuilder BuildDoors()
        {
            Vehicle["doors"] = "4";
            return this;
        }

        public override VehicleBuilder BuildEngine()
        {
            Vehicle["engine"] = "1900cc";
            return this;
        }

        public override VehicleBuilder BuildFrame()
        {
            Vehicle["frame"] = "Car Frame";
            return this;
        }

        public override VehicleBuilder BuildWheels()
        {
            Vehicle["wheels"] = "4";
            return this;
        }
    }
}
