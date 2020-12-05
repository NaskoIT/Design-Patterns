namespace ManuscriptMaker.ImplementatorModels
{
    /// <summary>
    /// The 'Implementor' abstract class
    /// </summary>
    public interface IFormatter
    {
        string Format(string key, string value);
    }
}
