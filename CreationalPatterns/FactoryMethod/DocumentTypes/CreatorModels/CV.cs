namespace DocumentTypes.CreatorModels
{
    using DocumentTypes.ProductModels;

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class CV : Document
    {
        public override void CreatePages()
        {
            base.Pages.Add(new BioPage());
            base.Pages.Add(new SkillsPage());
        }
    }
}
