namespace Kitchen.Models
{
    /// <summary>
    /// The 'ConcreteColleague' class
    /// </summary>
    public class Cook : Employee
    {
        public Cook(string name, IKitchenMediator mediator) 
            : base(name, mediator)
        {
        }
    }
}
