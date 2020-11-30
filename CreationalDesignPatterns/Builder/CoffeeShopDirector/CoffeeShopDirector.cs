namespace CoffeeShopDirector
{
    /// <summary>
    ///  The 'Director' class
    /// </summary>
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
