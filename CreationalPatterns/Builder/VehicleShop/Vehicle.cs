namespace VehicleShop
{
    using System;
    using System.Collections.Generic;

    using Builder.Common;

    /// <summary>
    ///  The 'Product' class
    /// </summary>
    public class Vehicle
    {
        private readonly string vehicleType;
        private readonly Dictionary<string, string> parts = new();

        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get => this.parts[key];
            set => this.parts[key] = value;
        }

        public void Show()
        {
            Console.WriteLine($"{Environment.NewLine}{new string('-', 30)}");
            Console.WriteLine(PrintMessages.VehicleType, vehicleType);
            Console.WriteLine(PrintMessages.Frame, parts[Constants.DisplayFrame]);
            Console.WriteLine(PrintMessages.Engine, parts[Constants.VehiclePartEngine]);
            Console.WriteLine(PrintMessages.Wheels, parts[Constants.VehiclePartWheels]);
            Console.WriteLine(PrintMessages.Doors, parts[Constants.VehiclePartDoors]);
        }
    }
}
