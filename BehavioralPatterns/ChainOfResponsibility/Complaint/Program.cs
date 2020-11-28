namespace Complaint
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Complaint complaint = new Complaint();
            Console.WriteLine("Customer Name: ");
            complaint.CustomerName = Console.ReadLine();
            Console.Write("Enter priority number: ");
            complaint.Priority = (Priority)int.Parse(Console.ReadLine());

            Employee employee = CoffeeShopChain.GetEmployee();
            employee.ProcessComplaint(complaint);

            Console.ReadKey(true);
        }
    }
}
