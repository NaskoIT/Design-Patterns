namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            var builders = new VehicleBuilder[]
            {
                new ScooterBuilder(),
                new MotorCycleBuilder(),
                new CarBuilder()
            };

            foreach (var builder in builders)
            {
                shop.Construct(builder);
                builder.Vehicle.Show();
            }
        }
    }
}
