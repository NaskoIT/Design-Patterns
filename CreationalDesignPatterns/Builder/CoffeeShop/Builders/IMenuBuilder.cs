namespace CoffeeShop.Builders
{
    /// <summary>
    ///  The 'Builder' interface 
    /// </summary>
    public interface IMenuBuilder
    {
        abstract IMenuBuilder AddHotDrink();

        abstract IMenuBuilder AddColdDrink();

        abstract IMenuBuilder AddDessert();

        Menu GetMenu();
    }
}
