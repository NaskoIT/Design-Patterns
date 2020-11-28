namespace EmployeeAdministration
{
    using System;

    /// <summary>
    /// The 'ConcreteVisitor' class
    /// </summary>
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            if (element is Employee employee)
            {
                employee.Income *= 1.1;
                Console.WriteLine($"{employee.GetType().Name} has new income: {employee.Income:F2}");
            }
        }
    }
}
