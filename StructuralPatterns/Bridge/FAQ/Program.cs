namespace FAQ
{
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var document = new List<Manuscript>();
            var fancyFormatter = new FancyFormatter();
            var standardFormatter = new StandardFormatter();

            var faq = new FAQ(standardFormatter)
            {
                Title = "The Bridge pattern"
            };

            faq.Questions.Add("What is it?", "A design pattern.");
            faq.Questions.Add("When do we use it?", "When you need to separate the abstraction from an implementation.");
            document.Add(faq);

            var book = new Book(fancyFormatter)
            {
                Author = "John Sonemz",
                Title = "Lots of Patterns",
                Text = "Blah blah blah"
            };

            document.Add(book);

            foreach (var doc in document)
            {
                doc.Print();
            }
        }
    }
}
