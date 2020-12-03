namespace CoffeeShop.Builders
{
    using Builder.Common;

    /// <summary>
    ///  The 'ConcreteBuilder' class
    /// </summary>
    public class FrenchBreakfastBuilder : IMenuBuilder
    {
        private Menu menu;

        public FrenchBreakfastBuilder()
        {
            this.menu = new Menu();
        }

        public IMenuBuilder AddHotDrink()
        {
            this.menu.HotDrink = Constants.DisplayDoubleCoffee;
            return this;
        }

        public IMenuBuilder AddColdDrink()
        {
            this.menu.ColdDrink = Constants.DisplayWater;
            return this;
        }

        public IMenuBuilder AddDessert()
        {
            this.menu.Dessert = Constants.DisplayCroissant;
            return this;
        }

        public Menu GetMenu() => this.menu;
    }
}
