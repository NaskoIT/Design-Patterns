namespace CoffeeShopDirector
{
    public class ItalianBreakfastBuilder : IMenuBuilder
    {
        private Menu menu;

        public ItalianBreakfastBuilder()
        {
            menu = new Menu();
        }

        public void AddHotDrink()
        {
            menu.HotDrink = "Cappuccino";
        }

        public void AddColdDrink()
        {
            menu.ColdDrink = "Juice";
        }

        public void AddDessert()
        {
            menu.Dessert = "Tiramisu";
        }

        public Menu GetMenu()
        {
            return menu;
        }
    }
}
