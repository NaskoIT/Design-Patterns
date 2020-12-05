namespace EmployeeAdministration.ElementModels
{
    using EmployeeAdministration.VisitorModels;

    /// <summary>
    /// The 'Element' abstract class
    /// </summary>
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}