namespace RestaurantComplaint.Models
{
    using System;

    using RestaurantComplaint.Enums;

    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    public abstract class Employee
    {
        protected Priority level;

        public void SetSuccessor(Employee successor)
        {
            this.Successor = successor;
        }

        public Employee Successor { get; private set; }

        public void ProcessComplaint(Complaint complaint)
        {
            if (complaint.Priority <= this.level)
            {
                Respond(complaint);
            }

            else if (this.Successor != null)
            {
                this.Successor.ProcessComplaint(complaint);
            }

            else
            {
                Console.WriteLine("Complaint cannot be handled!");
            }
        }

        protected virtual void Respond(Complaint complaint)
        {
            Console.WriteLine("Mr/Mrs {0}, your complaint will be handled by the {1}", complaint.CuromerName, this.GetType().Name.ToString());
        }
    }
}
