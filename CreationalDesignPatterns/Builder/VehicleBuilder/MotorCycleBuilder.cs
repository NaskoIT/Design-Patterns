namespace VehicleBuilder
{
    /// <summary>
    ///  The 'ConcreteBuilder' class
    /// </summary>
    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            Vehicle = new Vehicle("MotorCycle");
        }

        public override VehicleBuilder BuildDoors()
        {
            Vehicle["doors"] = "no";
            return this;
        }

        public override VehicleBuilder BuildEngine()
        {
            Vehicle["engine"] = "250cc";
            return this;
        }

        public override VehicleBuilder BuildFrame()
        {
            Vehicle["frame"] = "MotorCycle Frame";
            return this;
        }

        public override VehicleBuilder BuildWheels()
        {
            Vehicle["wheels"] = "2";
            return this;
        }
    }
}
