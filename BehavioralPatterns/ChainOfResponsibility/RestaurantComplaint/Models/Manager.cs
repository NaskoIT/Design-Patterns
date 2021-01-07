namespace RestaurantComplaint.Models
{
    using RestaurantComplaint.Enums;

    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public class Manager : Employee
    {
        public Manager(Priority level)
        {
            this.level = level;
        }
    }
}
