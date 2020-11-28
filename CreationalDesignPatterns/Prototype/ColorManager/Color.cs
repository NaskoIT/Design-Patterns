namespace ColorManager
{
    using System;

    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>
    public class Color : ColorPrototype
    {
        private readonly int red;
        private readonly int green;
        private readonly int blue;

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override ColorPrototype Clone()
        {
            Console.WriteLine($"Clonning color {this.ToString()}");
            return MemberwiseClone() as ColorPrototype;
        }

        public override string ToString()
        {
            return $"RGB: {red}, {green}, {blue}";
        }
    }
}
