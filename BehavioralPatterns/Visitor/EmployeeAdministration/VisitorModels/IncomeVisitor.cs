namespace EmployeeAdministration.VisitorModels
{
    using System;

    using EmployeeAdministration.ElementModels;
    using Visitor.Common;

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
                Console.WriteLine(PrintMessages.NewIncome, employee.GetType().Name, employee.Name, employee.Income);
            }
        }
    }
}
