namespace BuilderPattern
{
    /// <summary>
    ///  The 'Builder' abstract class
    /// </summary>
    public abstract class VehicleBuilder
    {
        public Vehicle Vehicle { get; protected set; }

        public abstract VehicleBuilder BuildFrame();

        public abstract VehicleBuilder BuildDoors();

        public abstract VehicleBuilder BuildWheels();

        public abstract VehicleBuilder BuildEngine();
    }
}
