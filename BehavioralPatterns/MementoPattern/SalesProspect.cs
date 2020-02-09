using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// The 'Originator' class
    /// </summary>
    public class SalesProspect
    {
        public SalesProspect(string name, string phone, double budget)
        {
            Name = name;
            Phone = phone;
            Budget = budget;
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public double Budget { get; set; }

        public Memento SaveMemento()
        {
            return new Memento(Name, Phone, Budget);
        }

        public void RestoreMemento(Memento memento)
        {
            Name = memento.Name;
            Phone = memento.Phone;
            Budget = memento.Budget;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nPhone: {Phone}\nBudget: {Budget}\n";
        }
    }
}
