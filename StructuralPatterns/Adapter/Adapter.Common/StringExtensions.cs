namespace Adapter.Common
{
    public static class StringExtensions
    {
        public static string ToCurrency(double num) => num.ToString("C");
    }
}
