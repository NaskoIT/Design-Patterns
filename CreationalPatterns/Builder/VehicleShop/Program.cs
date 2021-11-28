namespace VehicleShop
{
    using VehicleShop.Builders;

    public class Program
    {
        public static void Main()
        {
            Shop shop = new();

            var builders = new VehicleBuilder[]
            {
                new ScooterBuilder(),
                new MotorcycleBuilder(),
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
