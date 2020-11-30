namespace CoffeeShopDirector
{
    using CreationalDesignPatterns.Common;

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

        public void AddHotDrink()
        {
            this.menu.HotDrink = Constants.DisplayDoubleCoffee;
        }

        public void AddColdDrink()
        {
            this.menu.ColdDrink = Constants.DisplayWater;
        }

        public void AddDessert()
        {
            this.menu.Dessert = Constants.DisplayCroissant;
        }

        public Menu GetMenu() => this.menu;
    }
}
