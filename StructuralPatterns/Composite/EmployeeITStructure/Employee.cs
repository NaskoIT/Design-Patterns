namespace EmployeeITStructure
{
    using System.Collections;
    using System.Collections.Generic;

    using Composite.Common;

    /// <summary>
    /// The 'Composite' class
    /// </summary>
    public class Employee : IEmployee, IEnumerable
    {
        private readonly Dictionary<int, IEmployee> subordinates = new();

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

        public override string ToString() => string.Format(PrintMessages.Employee, this.Id, this.Position);
    }
}
