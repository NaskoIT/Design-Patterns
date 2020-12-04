namespace RestaurantComplaint.Models
{
    using RestaurantComplaint.Enums;

    public class Cook : Employee
    {
        public Cook(Priority level)
        {
            this.level = level;
        }
    }
}
