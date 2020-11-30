namespace CoffeeShopDirector
{
    /// <summary>
    ///  The 'Builder' interface 
    /// </summary>
    public interface IMenuBuilder
    {
        void AddHotDrink();

        void AddColdDrink();

        void AddDessert();

        Menu GetMenu();
    }
}
