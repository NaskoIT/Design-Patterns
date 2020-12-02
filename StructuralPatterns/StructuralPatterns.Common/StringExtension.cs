namespace StructuralPatterns.Common
{
    public static class StringExtension
    {
        public static string ToCurrency(double num) => num.ToString("C");
    }
}
