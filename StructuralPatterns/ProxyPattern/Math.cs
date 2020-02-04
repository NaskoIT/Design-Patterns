namespace ProxyPattern
{
    /// <summary>
    ///  The 'Real Subject' class
    /// </summary>
    public class Math : IMath
    {
        public double Add(double x, double y) => x + y;

        public double Sub(double x, double y) => x - y;

        public double Multiply(double x, double y) => x * y;
     
        public double Divide(double x, double y) => x / y;
    }
}
