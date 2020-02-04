using System;

namespace PrototypePattern
{
    class Program 
    {
        static void Main(string[] args)
        {
            Color color = new Color(10, 20, 30);
            Color otherColor = color.Clone() as Color;

            ColorManager colorManager = new ColorManager();

            colorManager["red"] = new Color(255, 0, 0);
            colorManager["green"] = new Color(0, 255, 0);
            colorManager["blue"] = new Color(0, 0, 255);

            var angryColor = colorManager["red"].Clone() as Color;
            var relaxColor = colorManager["green"].Clone() as Color;
            var peaceColor = colorManager["blue"].Clone() as Color;

            Console.WriteLine(angryColor);
            Console.WriteLine(relaxColor);
            Console.WriteLine(peaceColor);
        }
    }
}
