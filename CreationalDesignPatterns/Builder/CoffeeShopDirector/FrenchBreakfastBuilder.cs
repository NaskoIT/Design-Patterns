namespace CoffeeShopDirector
{
    public class FrenchBreakfastBuilder : IMenuBuilder
    {
        private Menu menu;

        public FrenchBreakfastBuilder()
        {
            menu = new Menu();
        }

        public void AddHotDrink()
        {
            menu.HotDrink = "Coffee";
        }

        public void AddColdDrink()
        {
            menu.ColdDrink = "Water";
        }

        public void AddDessert()
        {
            menu.Dessert = "Croissant";
        }

        public Menu GetMenu()
        {
            return menu;
        }
    }
}
