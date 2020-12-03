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
        private readonly Dictionary<string, string> parts = new Dictionary<string, string>();

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
            Console.WriteLine($"\n{new string('-', 30)}");
            Console.WriteLine(PrintMessages.VehicleTypePrintMessage, vehicleType);
            Console.WriteLine(PrintMessages.FramePrintMessage, parts[Constants.DisplayFrame.ToLower()]);
            Console.WriteLine(PrintMessages.EnginePrintMessage, parts[Constants.VehiclePartEngine]);
            Console.WriteLine(PrintMessages.WheelsPrintMessage, parts[Constants.VehiclePartWheels]);
            Console.WriteLine(PrintMessages.DoorsPrintMessage, parts[Constants.VehiclePartDoors]);
        }
    }
}
