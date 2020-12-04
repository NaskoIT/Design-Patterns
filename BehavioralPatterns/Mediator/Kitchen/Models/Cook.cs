namespace Kitchen.Models
{
    public class Cook : Employee
    {
        /// <summary>
        /// The 'ConcreteColleague' class
        /// </summary>
        public Cook(string name, IKitchenMediator mediator) 
            : base(name, mediator)
        {
        }
    }
}
