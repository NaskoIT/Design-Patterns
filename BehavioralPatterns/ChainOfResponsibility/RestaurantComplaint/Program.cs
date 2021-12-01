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
            Complaint complaint = new();
            Console.WriteLine(PrintMessages.ComplaintForm);

            Console.WriteLine(PrintMessages.CustomerName);
            complaint.CuromerName = Console.ReadLine();

            Console.Write(PrintMessages.EnterPriority);
            complaint.Priority = (Priority)int.Parse(Console.ReadLine());

            Employee employee = RestaurantChain.GetEmployee();
            employee.ProcessComplaint(complaint);
        }
    }
}
