namespace FAQ
{
    public class StandardFormatter : IFormatter
    {
        public string Format(string key, string value) => $"{key}: {value}";
    }
}
