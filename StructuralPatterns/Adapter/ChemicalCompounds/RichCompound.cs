namespace ChemicalCompounds
{
    using System;

    using Adapter.Common;

    /// <summary>
    /// The 'ConcreteAdapter' class
    /// </summary>
    public class RichCompound : ICompound
    {
        private readonly string chemical;
        private readonly ChemicalDatabank chemicalBank;
        private const string MessageTemplate = "{0}: {1}";

        public RichCompound(string chemical)
        {
            this.chemical = chemical;
            this.chemicalBank = new ChemicalDatabank();
        }

        public void Display()
        {
            var mocelularStructure = this.chemicalBank.GetMolecularStructure(this.chemical);
            var mocelularWeight = this.chemicalBank.GetMolecularWeigth(this.chemical);
            var meltingPoint = this.chemicalBank.GetCriticalPoint(this.chemical, Constants.SignMeltingPoint);
            var boilingPoint = this.chemicalBank.GetCriticalPoint(this.chemical, Constants.SignBoilingPoint);

            Console.WriteLine(MessageTemplate, Constants.DisplayCompound, this.chemical);
            Console.WriteLine(MessageTemplate, Constants.DisplayFormula, mocelularStructure);
            Console.WriteLine(MessageTemplate, Constants.DisplayWeight, mocelularWeight);

            Console.WriteLine(MessageTemplate, Constants.DisplayMeltingPoint, meltingPoint);
            Console.WriteLine(MessageTemplate + Environment.NewLine, Constants.DisplayBoilingPoint, boilingPoint);
        }
    }
}
