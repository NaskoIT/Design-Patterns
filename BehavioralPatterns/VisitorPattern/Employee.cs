namespace VisitorPattern
{
    /// <summary>
    /// The 'ConcreteElement' class
    /// </summary>
    public class Employee : Element
    {
        public Employee(string name, double income, int vocationDays)
        {
            Name = name;
            Income = income;
            VocationDays = vocationDays;
        }

        public string Name { get; set; }

        public double Income { get; set; }

        public int VocationDays { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
