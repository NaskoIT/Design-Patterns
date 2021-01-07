namespace RestaurantComplaint.Models
{
    using RestaurantComplaint.Enums;

    /// <summary>
    /// Class holding request details
    /// </summary>
    public class Complaint
    {
        public string CustomerName { get; set; }

        public Priority Priority { get; set; }
    }
}
