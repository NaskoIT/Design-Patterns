namespace RestaurantComplaint.Models
{
    using RestaurantComplaint.Enums;

    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public class Waiter : Employee
    {
        public Waiter(Priority level)
        {
            this.level = level;
        }
    }
}
