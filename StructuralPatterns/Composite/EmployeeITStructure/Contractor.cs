namespace EmployeeITStructure
{
    using Composite.Common;

    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    public class Contractor : IEmployee
    {
        public int Id { get; set; }

        public string Position { get; set; }

        public override string ToString() => string.Format(PrintMessages.Employee, this.Id, this.Position);
    }
}
