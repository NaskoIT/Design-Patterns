namespace Garage
{
    using System;

    using Facade.Common;
    using Garage.Models;

    /// <summary>
    /// The 'Facade' class
    /// </summary>
    public class GarageFacade
    {
        private readonly CarModel model;
        private readonly CarEngine engine;
        private readonly CarBody body;
        private readonly CarAccessories accessories;

        public GarageFacade()
        {
            model = new CarModel();
            engine = new CarEngine();
            body = new CarBody();
            accessories = new CarAccessories();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine(PrintMessages.CreatingCar);

            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

            Console.WriteLine(PrintMessages.CreatedCar);
        }
    }
}
