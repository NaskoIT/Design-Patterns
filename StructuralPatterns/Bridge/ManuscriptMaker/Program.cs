namespace ManuscriptMaker
{
    using System.Collections.Generic;

    using Bridge.Common;
    using ManuscriptMaker.AbstractionModels;
    using ManuscriptMaker.ImplementatorModels;

    public class Program
    {
        public static void Main()
        {
            var document = new List<Manuscript>();
            var fancyFormatter = new FancyFormatter();
            var standardFormatter = new StandardFormatter();

            var faq = new FAQ(standardFormatter)
            {
                Title = Constants.FaqTitle
            };

            faq.Questions.Add(Constants.FaqQuestionOne, Constants.FaqQuestionOneAnswer);
            faq.Questions.Add(Constants.FaqQuestionTwo, Constants.FaqQuestionTwoAnswer);
            document.Add(faq);

            var book = new Book(fancyFormatter)
            {
                Author = Constants.BookAuthor,
                Title = Constants.BookTitle,
                Text = Constants.BookText,
            };

            document.Add(book);

            foreach (var doc in document)
            {
                doc.Print();
            }
        }
    }
}
