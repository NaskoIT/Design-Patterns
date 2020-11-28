namespace Document.Documents
{
    using global::Document.Pages;

    public class Report : Document
    {
        public override void CreatePages()
        {
            base.Pages.Add(new ResultsPage());
            base.Pages.Add(new SummaryPage());
        }
    }
}
