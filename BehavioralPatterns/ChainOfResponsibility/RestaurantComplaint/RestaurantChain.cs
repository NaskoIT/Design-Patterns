namespace RestaurantComplaint
{
    using RestaurantComplaint.Enums;
    using RestaurantComplaint.Models;

    public class RestaurantChain
    {
        public static Employee GetEmployee()
        {
            Employee waiter = new Waiter(Priority.Low);
            Employee cook = new Cook(Priority.Medium);
            Employee manager = new Manager(Priority.High);

            waiter.SetSuccessor(cook);
            cook.SetSuccessor(manager);

            return waiter;
        }
    }
}
