namespace EmployeeAdministration.VisitorModels
{
    using EmployeeAdministration.ElementModels;

    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    public interface IVisitor
    {
        void Visit(Element element);
    }
}