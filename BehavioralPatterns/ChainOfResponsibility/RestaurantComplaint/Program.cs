namespace RestaurantComplaint
{
    using System;

    using ChainOfResponsibility.Common;
    using RestaurantComplaint.Enums;
    using RestaurantComplaint.Models;

    public class Program
    {
        public static void Main()
        {
            Complaint complaint = new Complaint();
            Console.WriteLine(PrintMessages.CompaintForm);
            Console.WriteLine(PrintMessages.CustomerName);
            complaint.CustomerName = Console.ReadLine();
            Console.Write(PrintMessages.EnterPriority);
            complaint.Priority = (Priority)int.Parse(Console.ReadLine());

            Employee employee = RestaurantChain.GetEmployee();
            employee.ProcessComplaint(complaint);
        }
    }
}
