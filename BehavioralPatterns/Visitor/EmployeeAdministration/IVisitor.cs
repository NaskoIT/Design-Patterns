namespace EmployeeAdministration
{
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    public interface IVisitor
    {
        void Visit(Element element);
    }
}