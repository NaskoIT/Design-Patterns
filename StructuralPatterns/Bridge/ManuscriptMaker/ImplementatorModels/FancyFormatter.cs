namespace ManuscriptMaker.ImplementatorModels
{
    /// <summary>
    /// The 'ConcreteImplementorA' class
    /// </summary>
    public class FancyFormatter : IFormatter
    {
        public string Format(string key, string value) => $"{key} => {value}";
    }
}