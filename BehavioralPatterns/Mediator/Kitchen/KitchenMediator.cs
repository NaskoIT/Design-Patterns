namespace Kitchen
{
    using System.Collections.Generic;

    using Kitchen.Models;

    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    public class KitchenMediator : IKitchenMediator
    {
        private readonly Dictionary<string, Employee> employees = 
            new Dictionary<string, Employee>();

        public void Register(Employee employee)
        {
            if (!this.employees.ContainsValue(employee))
            {
                this.employees[employee.Name] = employee;
            }
            employee.Mediator = this;
        }

        public void SendMessage(string from, string to, string message)
        {
            Employee employee = this.employees[to];

            if (employee != null)
            {
                employee.Receive(from, message);
            }
        }
    }
}
