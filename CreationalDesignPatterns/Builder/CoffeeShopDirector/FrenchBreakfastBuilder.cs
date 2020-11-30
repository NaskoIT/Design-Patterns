namespace CoffeeShopDirector
{
    public class FrenchBreakfastBuilder : IMenuBuilder
    {
        private Menu menu;

        public FrenchBreakfastBuilder()
        {
            this.menu = new Menu();
        }

        public void AddHotDrink()
        {
            this.menu.HotDrink = "Coffee";
        }

        public void AddColdDrink()
        {
            this.menu.ColdDrink = "Water";
        }

        public void AddDessert()
        {
            this.menu.Dessert = "Croissant";
        }

        public Menu GetMenu() => this.menu;
    }
}
