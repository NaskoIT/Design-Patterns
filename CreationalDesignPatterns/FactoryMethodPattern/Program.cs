using FactoryMethodPattern.Documents;
using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var documents = new Document[]
            {
                new CV(),
                new Report()
            };

            foreach (var document in documents)
            {
                Console.WriteLine(document.GetType().Name);
                for (int i = 0; i < document.Pages.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {document.Pages[i].GetType().Name}");
                }
            }
        }
    }
}
