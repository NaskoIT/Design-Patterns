namespace ProspectState
{
    /// <summary>
    /// The 'Memento' class
    /// </summary>
    public class Memento
    {
        public Memento(string name, string phone, double budget)
        {
            this.Name = name;
            this.Phone = phone;
            this.Budget = budget;
        }

        public string Name { get; private set; }

        public string Phone { get; private set; }

        public double Budget { get; private set; }
    }
}