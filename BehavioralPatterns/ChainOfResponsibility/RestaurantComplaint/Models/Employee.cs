namespace RestaurantComplaint.Models
{
    using System;

    using RestaurantComplaint.Enums;

    public abstract class Employee
    {
        protected Priority level;

        public Employee successor;

        public void SetSuccessor(Employee successor)
        {
            this.successor = successor;
        }

        public void ProcessComplaint(Complaint complaint)
        {
            if (complaint.Priority <= this.level)
            {
                Respond(complaint);
            }

            else if (this.successor != null)
            {
                this.successor.ProcessComplaint(complaint);
            }

            else
            {
                Console.WriteLine("Complaint cannot be handled!");
            }
        }

        protected virtual void Respond(Complaint complaint)
        {
            Console.WriteLine("Mr/Mrs {0}, your complaint will be handled by the {1}", complaint.CustomerName, this.GetType().Name.ToString());
        }
    }
}
