namespace Garage.Models
{    
    using System;

    using Facade.Common;

    /// <summary>
    /// The 'Subsystem ClassB' class
    /// </summary>
    internal class CarEngine
    {
        public void SetEngine()
        {
            Console.WriteLine(PrintMessages.CarEnginePrintMessage);
        }
    }
}
