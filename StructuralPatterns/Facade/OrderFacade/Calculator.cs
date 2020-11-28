namespace OrderFacade
{
    public class Calculator
    {
        public int Sum(Order order)
        {
            int sum = 0;

            foreach (Drink drink in order.Drinks)
            {
                sum += drink.Price;
            }

            return sum;
        }
    }
}
