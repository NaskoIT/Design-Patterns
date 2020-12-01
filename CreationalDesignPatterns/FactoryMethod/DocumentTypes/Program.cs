namespace DocumentTypes
{
    using System;
    using DocumentTypes.Documents;

    public class Program
    {
        public static void Main()
        {
            var documents = new Document[]
            {
                new CV(),
                new Report()
            };

            foreach (var document in documents)
            {
                var documentTypeName = document.GetType().Name;
                Console.WriteLine(documentTypeName);
                for (int i = 0; i < document.Pages.Count; i++)
                {
                    var pageTypeName = document.Pages[i].GetType().Name;
                    Console.WriteLine($"{i + 1}. {pageTypeName}");
                }
            }
        }
    }
}
