namespace DocumentTypes.CreatorModels
{
    using DocumentTypes.ProductModels;

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class Report : Document
    {
        public override void CreatePages()
        {
            base.Pages.Add(new ResultsPage());
            base.Pages.Add(new SummaryPage());
        }
    }
}
