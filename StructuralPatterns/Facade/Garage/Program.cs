namespace Garage
{
    public class Program
    {
        public static void Main()
        {
            GarageFacade carFacade = new();
            carFacade.CreateCompleteCar();
        }
    }
}
