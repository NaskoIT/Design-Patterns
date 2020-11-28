namespace Kitchen
{
    using System.Collections.Generic;

    public class Mediator : IMediator
    {
        private Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

        public void Register(Employee employee)
        {
            if (!employees.ContainsValue(employee))
            {
                employees[employee.Name] = employee;
            }
            employee.Mediator = this;
        }

        public void SendMessage(string from, string to, string message)
        {
            Employee employee = employees[to];

            if (employee != null)
            {
                employee.Receive(from, message);
            }
        }
    }
}
