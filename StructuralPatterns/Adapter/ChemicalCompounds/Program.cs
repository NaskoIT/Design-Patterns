namespace ChemicalCompounds
{
    using Adapter.Common;

    public class Program
    {
        public static void Main()
        {
            ICompound water = new RichCompound(Constants.DisplayWater);
            water.Display();
            
            ICompound benzene = new RichCompound(Constants.DisplayBenzene);
            benzene.Display();

            ICompound ethanol = new RichCompound(Constants.DisplayEthanol);
            ethanol.Display();
        }
    }
}
