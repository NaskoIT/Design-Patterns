namespace VehicleShop.Builders
{
    using Builder.Common;

    /// <summary>
    ///  The 'ConcreteBuilder' class
    /// </summary>
    public class MotorcycleBuilder : VehicleBuilder
    {
        public MotorcycleBuilder()
        {
            Vehicle = new Vehicle(Constants.DisplayMotorcycle);
        }

        public override VehicleBuilder BuildDoors()
        {
            Vehicle[Constants.VehiclePartDoors] = Constants.StringOptionNo;
            return this;
        }

        public override VehicleBuilder BuildEngine()
        {
            Vehicle[Constants.VehiclePartEngine] = Constants.StringMotorcycleEngineCapacity;
            return this;
        }

        public override VehicleBuilder BuildFrame()
        {
            Vehicle[Constants.DisplayFrame] = Constants.DisplayMotorcycle + " " + Constants.DisplayFrame;
            return this;
        }

        public override VehicleBuilder BuildWheels()
        {
            Vehicle[Constants.VehiclePartWheels] = Constants.StringNumberTwo;
            return this;
        }
    }
}
