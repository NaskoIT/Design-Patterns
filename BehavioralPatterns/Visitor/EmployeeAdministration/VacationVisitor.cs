namespace EmployeeAdministration
{
    using System;

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
                Console.WriteLine($"{employee.GetType().Name} {employee.Name} has new vacation days: {employee.VacationDays}\n");
            }
        }
    }
}
