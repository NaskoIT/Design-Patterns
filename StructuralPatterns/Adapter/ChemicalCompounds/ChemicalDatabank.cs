namespace ChemicalCompounds
{
    using Adapter.Common;

    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    internal class ChemicalDatabank
    {
        // The databank leggacy API
        public float GetCriticalPoint(string compound, string point)
        {
            if (point == Constants.SignMeltingPoint)
            {
                // Melting point
                return (compound.ToLower()) switch
                {
                    Constants.DisplayWaterCompound => 0.0f,
                    Constants.DisplayBenzeneCompound => 5.5f,
                    Constants.DisplayEthanolCompound => -114.1f,
                    _ => 0f,
                };
            }
            else
            {
                // Boiling point
                return (compound.ToLower()) switch
                {
                    Constants.DisplayWaterCompound => 100.0f,
                    Constants.DisplayBenzeneCompound => 80.1f,
                    Constants.DisplayEthanolCompound => 78.3f,
                    _ => 0f,
                };
            }
        }

        public string GetMolecularStructure(string compound)
        {
            return compound.ToLower() switch
            {
                Constants.DisplayWaterCompound => "H2O",
                Constants.DisplayBenzeneCompound => "C6H6",
                Constants.DisplayEthanolCompound => "C2H5OH",
                _ => null,
            };
        }

        public double GetMolecularWeigth(string compound)
        {
            return compound.ToLower() switch
            {
                Constants.DisplayWaterCompound => 18.015,
                Constants.DisplayBenzeneCompound => 78.1134,
                Constants.DisplayEthanolCompound => 46.0688,
                _ => 0,
            };
        }
    }
}
