namespace RestaurantComplaint.Models
{
    using RestaurantComplaint.Enums;

    public class Waiter : Employee
    {
        public Waiter(Priority level)
        {
            this.level = level;
        }
    }
}
