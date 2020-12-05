namespace RestaurantComplaint.Models
{
    using RestaurantComplaint.Enums;

    public class Complaint
    {
        public string CustomerName { get; set; }

        public Priority Priority { get; set; }
    }
}
