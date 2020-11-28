namespace Employee
{
    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    public class Contractor : IEmployee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id = {Id},Name = {Name}";
        }
    }
}
