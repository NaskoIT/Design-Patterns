namespace Bar.Models
{
    /// <summary>
    /// The 'Subsystem ClassC' class
    /// </summary>
    public class Calculator
    {
        public double Sum(Order order)
        {
            double sum = 0;

            foreach (Drink drink in order.Drinks)
            {
                sum += drink.Price;
            }

            return sum;
        }
    }
}
