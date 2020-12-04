namespace Kitchen.Models
{
    public class Waiter : Employee
    {
        /// <summary>
        /// The 'ConcreteColleague' class
        /// </summary>
        public Waiter(string name, IKitchenMediator mediator) 
            : base(name, mediator)
        {
        }
    }
}
