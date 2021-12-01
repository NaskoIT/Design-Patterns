namespace Kitchen.Models
{
    /// <summary>
    /// The 'ConcreteColleague' class
    /// </summary>
    public class Waiter : Employee
    {
        public Waiter(string name, IKitchenMediator mediator) 
            : base(name, mediator)
        {
        }
    }
}
