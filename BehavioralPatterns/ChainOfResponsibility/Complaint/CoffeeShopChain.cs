namespace Complaint
{
    public class CoffeeShopChain
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
