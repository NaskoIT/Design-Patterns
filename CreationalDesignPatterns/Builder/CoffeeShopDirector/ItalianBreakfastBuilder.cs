namespace CoffeeShopDirector
{
    using CreationalDesignPatterns.Common;

    /// <summary>
    ///  The 'ConcreteBuilder' class
    /// </summary>
    public class ItalianBreakfastBuilder : IMenuBuilder
    {
        private Menu menu;

        public ItalianBreakfastBuilder()
        {
            this.menu = new Menu();
        }

        public void AddHotDrink()
        {
            this.menu.HotDrink = Constants.DisplayCappuccino;
        }

        public void AddColdDrink()
        {
            this.menu.ColdDrink = Constants.DisplayJuice;
        }

        public void AddDessert()
        {
            this.menu.Dessert = Constants.DisplayTiramisu;
        }

        public Menu GetMenu() => this.menu;
    }
}
