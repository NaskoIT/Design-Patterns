namespace CoffeeShop.Builders
{
    using Builder.Common;

    /// <summary>
    ///  The 'ConcreteBuilder' class
    /// </summary>
    public class ItalianBreakfastBuilder : IMenuBuilder
    {
        private readonly Menu menu;

        public ItalianBreakfastBuilder()
        {
            this.menu = new Menu();
        }

        public IMenuBuilder AddHotDrink()
        {
            this.menu.HotDrink = Constants.DisplayCappuccino;
            return this;
        }

        public IMenuBuilder AddColdDrink()
        {
            this.menu.ColdDrink = Constants.DisplayJuice;
            return this;
        }

        public IMenuBuilder AddDessert()
        {
            this.menu.Dessert = Constants.DisplayTiramisu;
            return this;
        }

        public Menu GetMenu() => this.menu;
    }
}
