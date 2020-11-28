namespace MathProxy
{
    using System;

    /// <summary>
    ///  The 'Proxy Object' class
    /// </summary>
    public class MathProxy : IMath
    {
        private readonly Math math = new Math();

        public double Add(double x, double y)
        {
            //Do some security checks , parameters changes, logging, validations
            return math.Add(x, y);
        }

        public double Divide(double x, double y)
        {
            //Do some security checks , parameters changes, logging, validations
            if (y == 0)
            {
                throw new DivideByZeroException();
            }

            return math.Divide(x, y);
        }

        public double Multiply(double x, double y)
        {
            //Do some security checks , parameters changes, logging, validations
            return math.Multiply(x, y);
        }

        public double Sub(double x, double y)
        {
            //Do some security checks , parameters changes, logging, validations
            return math.Sub(x, y);
        }
    }
}
