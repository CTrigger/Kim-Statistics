using System.Linq;

namespace StastisticsCore
{
    public class MeanDataCore : DataCore
    {
        public double WeightedAritmeticMean { get => Dataset.Sum(d => (d.Y * d.X) / SumOfFrequencies); }
        public double WeightedGeometricMean { get => Dataset.Aggregate(0.0, (acc, d) => acc * System.Math.Pow(d.X, d.Y / SumOfFrequencies)); }
        public double WeightedHarmonicMean { get => SumOfFrequencies / Dataset.Sum(d => d.Y / d.X); }



    }
}
