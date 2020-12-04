namespace RestaurantComplaint.Models
{
    using RestaurantComplaint.Enums;

    public class Manager : Employee
    {
        public Manager(Priority level)
        {
            this.level = level;
        }
    }
}
