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
            var manuscripts = new List<Manuscript>();
            var fancyFormatter = new FancyFormatter();
            var standardFormatter = new StandardFormatter();

            var faq = new FAQ(standardFormatter)
            {
                Title = Constants.Title
            };

            faq.Questions.Add(Constants.QuestionOne, Constants.QuestionOneAnswer);
            faq.Questions.Add(Constants.QuestionTwo, Constants.QuestionTwoAnswer);
            manuscripts.Add(faq);

            var book = new Book(fancyFormatter)
            {
                Author = Constants.BookAuthor,
                Title = Constants.BookTitle,
                Text = Constants.BookText,
            };

            manuscripts.Add(book);

            foreach (var page in manuscripts)
            {
                page.Print();
            }
        }
    }
}
