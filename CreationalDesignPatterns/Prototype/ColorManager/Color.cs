namespace ColorManager
{
    using System;

    using Prototype.Common;

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
            Console.WriteLine(PrintMessages.ClonningColorPrintMessage, this.ToString());
            return MemberwiseClone() as ColorPrototype;
        }

        public override string ToString() => $"RGB: {this.red}, {this.green}, {this.blue}";
    }
}
