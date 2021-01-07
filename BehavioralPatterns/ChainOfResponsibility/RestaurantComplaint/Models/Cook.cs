namespace RestaurantComplaint.Models
{
    using RestaurantComplaint.Enums;

    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public class Cook : Employee
    {
        public Cook(Priority level)
        {
            this.level = level;
        }
    }
}
