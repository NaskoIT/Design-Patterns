namespace EmployeeAdministration
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Clerk("Peter"),
                new Director("Nasko"),
                new President("Georgi")
            };

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.GetType().Name} has vacation days: {employee.VacationDays}");
                Console.WriteLine($"{employee.GetType().Name} has income: {employee.Income}\n");
            }

            Console.WriteLine($"Visiting employees with {nameof(IncomeVisitor)} and {nameof(VacationVisitor)}\n");

            foreach (var employee in employees)
            {
                employee.Accept(new IncomeVisitor());
                employee.Accept(new VacationVisitor());
            }
        }
    }
}
