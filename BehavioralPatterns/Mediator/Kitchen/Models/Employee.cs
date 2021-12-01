namespace Kitchen.Models
{
    using System;

    using Mediator.Common;

    /// <summary>
    /// The 'Colleague' class
    /// </summary>
    public abstract class Employee
    {
        public Employee(string name, IKitchenMediator mediator)
        {
            this.Name = name;
            this.Mediator = mediator;
        }

        public string Name { get; private set; }

        public IKitchenMediator Mediator { get; set; }

        public void Send(string to, string message) => this.Mediator.SendMessage(this.Name, to, message);

        public void Receive(string from, string message)
        {
            Console.WriteLine(PrintMessages.Response, from, this.Name, message);
        }
    }
}
