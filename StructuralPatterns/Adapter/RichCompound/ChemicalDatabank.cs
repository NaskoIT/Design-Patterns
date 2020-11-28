namespace RichCompound
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    internal class ChemicalDatabank
    {
        //The databank leggacy API
        public float GetCriticalPoint(string compound, string point)
        {
            if (point == "M")
            {
                //Melting point
                return (compound.ToLower()) switch
                {
                    "water" => 0.0f,
                    "benzene" => 5.5f,
                    "ethanol" => -114.1f,
                    _ => 0f,
                };
            }
            else
            {
                //Boiling point
                return (compound.ToLower()) switch
                {
                    "water" => 100.0f,
                    "benzene" => 80.1f,
                    "ethanol" => 78.3f,
                    _ => 0f,
                };
            }
        }

        public string GetMolecularStructure(string compound)
        {
            return compound.ToLower() switch
            {
                "water" => "H2O",
                "benzene" => "C6H6",
                "ethanol" => "C2H5OH",
                _ => null,
            };
        }

        public double GetMolecularWeigth(string compound)
        {
            return compound.ToLower() switch
            {
                "water" => 18.015,
                "benzene" => 78.1134,
                "ethanol" => 46.0688,
                _ => 0,
            };
        }
    }
}
