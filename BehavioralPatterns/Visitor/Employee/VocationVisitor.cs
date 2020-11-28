namespace VisitorPattern
{
    using System;

    /// <summary>
    /// The 'ConcreteVisitor' class
    /// </summary>
    public class VocationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            if (element is Employee employee)
            {
                employee.VocationDays += 3;
                Console.WriteLine($"{employee.GetType().Name} {employee.Name} has new vocation days: {employee.VocationDays}\n");
            }
        }
    }
}
