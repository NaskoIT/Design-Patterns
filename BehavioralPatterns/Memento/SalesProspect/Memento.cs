namespace SalesProspect
{
    /// <summary>
    /// The 'Memento' class
    /// </summary>
    public class Memento
    {
        public Memento(string name, string phone, double budget)
        {
            Name = name;
            Phone = phone;
            Budget = budget;
        }

        public string Name { get; private set; }

        public string Phone { get; private set; }

        public double Budget { get; private set; }
    }
}