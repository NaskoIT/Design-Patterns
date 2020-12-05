namespace VehicleShop.Builders
{
    using Builder.Common;

    /// <summary>
    ///  The 'ConcreteBuilder' class
    /// </summary>
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            Vehicle = new Vehicle(Constants.DisplayScooter);
        }

        public override VehicleBuilder BuildDoors()
        {
            Vehicle[Constants.VehiclePartDoors] = Constants.StringOptionNo;
            return this;
        }

        public override VehicleBuilder BuildEngine()
        {
            Vehicle[Constants.VehiclePartEngine] = Constants.StringScooterEngineCapacity;
            return this;
        }

        public override VehicleBuilder BuildFrame()
        {
            Vehicle[Constants.DisplayFrame.ToLower()] = Constants.DisplayScooter + " " + Constants.DisplayFrame;
            return this;
        }

        public override VehicleBuilder BuildWheels()
        {
            Vehicle[Constants.VehiclePartWheels] = Constants.StringNumberTwo;
            return this;
        }
    }
}
