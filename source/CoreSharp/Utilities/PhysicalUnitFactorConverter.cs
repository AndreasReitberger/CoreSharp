using AndreasReitberger.Core.Enums;
using System.Collections.Generic;

namespace AndreasReitberger.Core.Utilities
{
    public class PhysicalUnitFactorConverter
    {
        public static Dictionary<PhysicalUnit, double> UnitFactors = new()
        {
            {PhysicalUnit.Gram, 1 },
            {PhysicalUnit.KiloGram, 1000 },
            {PhysicalUnit.Ton, 1000000 },
            {PhysicalUnit.CentiLiters, 0.1f },
            {PhysicalUnit.MiliLiters, 1 },
            {PhysicalUnit.Liters, 1000 },
        };
        public static double GetUnitFactor(PhysicalUnit unit)
        {
            if (UnitFactors.ContainsKey(unit))
                return UnitFactors[unit];
            else return 1;
        }
    }
}
