namespace Kitchen
{
    using System;

    public abstract class Employee
    {
        public string Name { get; set; }

        public IMediator Mediator { get; set; }

        public Employee(string name, IMediator mediator)
        {
            Name = name;
            Mediator = mediator;
        }

        public void Send(string to, string message)
        {
            Mediator.SendMessage(Name, to, message);
        }

        public void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: {2}", from, Name, message);
        }
    }
}
