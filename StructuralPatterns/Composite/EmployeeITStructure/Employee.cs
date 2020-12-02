namespace EmployeeITStructure
{
    using System.Collections;
    using System.Collections.Generic;

    using StructuralPatterns.Common;

    /// <summary>
    /// The 'Composite' class
    /// </summary>
    public class Employee : IEmployee, IEnumerable
    {
        private readonly Dictionary<int, IEmployee> subordinates = new Dictionary<int, IEmployee>();

        public int Id { get; set; }

        public string Position { get; set; }

        public void AddSubordinate(IEmployee subordinate) => this.subordinates.Add(subordinate.Id, subordinate);

        public void RemoveSubordinate(int subordinateId) => this.subordinates.Remove(subordinateId);

        public IEmployee GetSubordinate(int subordinateId) => this.subordinates[subordinateId];

        public IEnumerator<IEmployee> GetEnumerator()
        {
            foreach (var subordinate in this.subordinates.Values)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString() => string.Format(PrintMessages.EmployeePrintMessage, this.Id, this.Position);
    }
}
