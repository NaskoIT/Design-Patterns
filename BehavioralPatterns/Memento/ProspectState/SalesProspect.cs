namespace ProspectState
{
    /// <summary>
    /// The 'Originator' class
    /// </summary>
    public class SalesProspect
    {
        public SalesProspect(string name, string phone, double budget)
        {
            this.Name = name;
            this.Phone = phone;
            this.Budget = budget;
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public double Budget { get; set; }

        public ProspectMemento SaveMemento() => new(this.Name, this.Phone, this.Budget);

        public void RestoreMemento(ProspectMemento memento)
        {
            this.Name = memento.Name;
            this.Phone = memento.Phone;
            this.Budget = memento.Budget;
        }

        public override string ToString() => $"Name: {this.Name}\nPhone: {this.Phone}\nBudget: {this.Budget}\n";
    }
}
