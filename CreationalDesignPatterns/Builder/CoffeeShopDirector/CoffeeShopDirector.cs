namespace CoffeeShopDirector
{
    public class CoffeeShopDirector
    {
        public void Construct(IMenuBuilder builder)
        {
            builder.AddHotDrink();
            builder.AddColdDrink();
            builder.AddDessert();
        }
    }
}
