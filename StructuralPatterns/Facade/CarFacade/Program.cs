namespace FacadePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CarFacade carFacade = new CarFacade();
            carFacade.CreateCompleteCar();
        }
    }
}
