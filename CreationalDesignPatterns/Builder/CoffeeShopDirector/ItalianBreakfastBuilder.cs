namespace CoffeeShopDirector
{
    public class ItalianBreakfastBuilder : IMenuBuilder
    {
        private Menu menu;

        public ItalianBreakfastBuilder()
        {
            this.menu = new Menu();
        }

        public void AddHotDrink()
        {
            this.menu.HotDrink = "Cappuccino";
        }

        public void AddColdDrink()
        {
            this.menu.ColdDrink = "Juice";
        }

        public void AddDessert()
        {
            this.menu.Dessert = "Tiramisu";
        }

        public Menu GetMenu() => this.menu;
    }
}
