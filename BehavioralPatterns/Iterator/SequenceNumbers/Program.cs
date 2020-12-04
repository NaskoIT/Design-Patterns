namespace SequenceNumbers
{
    using System;
    using System.Collections.Generic;

    using Iterator.Common;
    using SequenceNumbers.Contracts;
    using SequenceNumbers.Models;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(PrintMessages.CustomIterator);
            ConcreteAggregate<int> collection = new ConcreteAggregate<int>();
            collection.Add(1);
            collection.Add(2);
            collection.Add(3);
            collection.Add(4);
            collection.Add(5);

            IIterator<int> iterator = collection.CreateIterator();
            while (iterator.Next())
            {
                int item = iterator.Current;
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 50));

            Console.WriteLine(PrintMessages.NETIterator);
            IEnumerable<int> elements = new List<int>() { 1, 2, 3, 4, 5 };

            IEnumerator<int> enumerator = elements.GetEnumerator();
            while (enumerator.MoveNext())
            {
                int currentElement = enumerator.Current;
                Console.WriteLine(currentElement);
            }
        }
    }
}
