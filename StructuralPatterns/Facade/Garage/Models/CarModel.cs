namespace Garage.Models
{
    using System;

    using Facade.Common;

    /// <summary>
    /// The 'Subsystem ClassA' class
    /// </summary>
    internal class CarModel
    {
        public void SetModel()
        {
            Console.WriteLine(PrintMessages.CarModelPrintMessage);
        }
    }
}
