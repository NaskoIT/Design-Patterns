namespace CoffeeShop
{
    using CoffeeShop.Builders;

    /// <summary>
    ///  The 'Director' class
    /// </summary>
    public class Shop
    {
        public void Construct(IMenuBuilder builder)
        {
            builder
                .AddHotDrink()
                .AddColdDrink()
                .AddDessert();
        }
    }
}
