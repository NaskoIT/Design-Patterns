namespace BuilderPattern
{
    /// <summary>
    ///  The 'ConcreteBuilder' class
    /// </summary>
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            Vehicle = new Vehicle("Scooter");
        }

        public override VehicleBuilder BuildDoors()
        {
            Vehicle["doors"] = "no";
            return this;
        }

        public override VehicleBuilder BuildEngine()
        {
            Vehicle["engine"] = "50cc";
            return this;
        }

        public override VehicleBuilder BuildFrame()
        {
            Vehicle["frame"] = "Scooter Frame";
            return this;
        }

        public override VehicleBuilder BuildWheels()
        {
            Vehicle["wheels"] = "2";
            return this;
        }
    }
}
