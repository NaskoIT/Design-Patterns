namespace VehicleShop
{
    using System;
    using System.Collections.Generic;

    using CreationalDesignPatterns.Common;

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
            Console.WriteLine($"Vehicle Type: {vehicleType}");
            Console.WriteLine($" Frame: {parts[Constants.DisplayFrame.ToLower()]}");
            Console.WriteLine($" Engine: {parts[Constants.VehiclePartEngine]}");
            Console.WriteLine($" #Wheels: {parts[Constants.VehiclePartWheels]}");
            Console.WriteLine($" #Doors: {parts[Constants.VehiclePartDoors]}");
        }
    }
}
