namespace Employee
{
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// The 'Composite' class
    /// </summary>
    public class Employee : IEmployee, IEnumerable
    {
        private readonly Dictionary<int, IEmployee> subordinates = new Dictionary<int, IEmployee>();

        public int Id { get; set; }

        public string Name { get; set; }

        public void AddSubordinate(IEmployee subordinate) => subordinates.Add(subordinate.Id, subordinate);

        public void RemoveSubordinate(int subordinateId) => subordinates.Remove(subordinateId);

        public IEmployee GetSubordinate(int subordinateId) => subordinates[subordinateId];

        public IEnumerator<IEmployee> GetEnumerator()
        {
            foreach (var subordinate in subordinates.Values)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString()
        {
            return $"Id = {Id},Name = {Name}";
        }
    }
}
