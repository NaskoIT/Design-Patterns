namespace EmployeeAdministration.VisitorModels
{
    using System;

    using EmployeeAdministration.ElementModels;
    using Visitor.Common;

    /// <summary>
    /// The 'ConcreteVisitor' class
    /// </summary>
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            if (element is Employee employee)
            {
                employee.VacationDays += 3;
                Console.WriteLine(PrintMessages.NewVacationDays, employee.GetType().Name, employee.Name, employee.VacationDays);
            }
        }
    }
}
