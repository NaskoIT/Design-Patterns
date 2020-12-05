namespace VehicleShop.Builders
{
    using Builder.Common;

    /// <summary>
    ///  The 'ConcreteBuilder' class
    /// </summary>
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            Vehicle = new Vehicle(Constants.DisplayCar);
        }

        public override VehicleBuilder BuildDoors()
        {
            Vehicle[Constants.VehiclePartDoors] = Constants.StringNumberFour;
            return this;
        }

        public override VehicleBuilder BuildEngine()
        {
            Vehicle[Constants.VehiclePartEngine] = Constants.StringCarEngineCapacity;
            return this;
        }

        public override VehicleBuilder BuildFrame()
        {
            Vehicle[Constants.DisplayFrame.ToLower()] = Constants.DisplayCar + " " + Constants.DisplayFrame;
            return this;
        }

        public override VehicleBuilder BuildWheels()
        {
            Vehicle[Constants.VehiclePartWheels] = Constants.StringNumberFour;
            return this;
        }
    }
}
