namespace AdapterPattern
{
    using System;

    /// <summary>
    /// The 'ConcreteAdapter' class
    /// </summary>
    public class RichCompound : ICompound
    {
        private readonly string chemical;
        private readonly ChemicalDatabank chemicalBank;

        public RichCompound(string chemical)
        {
            this.chemical = chemical;
            chemicalBank = new ChemicalDatabank();
        }

        public void Display()
        {
            Console.WriteLine($"Compound: {chemical}");
            Console.WriteLine($"Formula: {chemicalBank.GetMolecularStructure(chemical)}");
            Console.WriteLine($"Weight: {chemicalBank.GetMolecularWeigth(chemical)}");
            Console.WriteLine($"Melting Point: {chemicalBank.GetCriticalPoint(chemical, "M")}");
            Console.WriteLine($"Boiling Point: {chemicalBank.GetCriticalPoint(chemical, "B")}\n");
        }
    }
}
