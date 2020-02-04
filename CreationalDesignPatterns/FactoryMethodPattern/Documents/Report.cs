using FactoryMethodPattern.Pages;

namespace FactoryMethodPattern.Documents
{
    public class Report : Document
    {
        public override void CreatePages()
        {
            base.Pages.Add(new ResultsPage());
            base.Pages.Add(new SummaryPage());
        }
    }
}
