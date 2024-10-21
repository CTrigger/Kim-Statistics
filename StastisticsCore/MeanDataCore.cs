using System;
using System.Linq;
namespace StastisticsCore
{
    public class MeanDataCore : DataCore
    {
        public double WeightedAritmeticMean { get => Dataset.Sum(d => (d.Y * d.X) / SumOfFrequencies); }
        // To fix public double WeightedGeometricMean { get => Dataset.Aggregate(0.0, (acc, d) => acc * Math.Pow(d.X, d.Y / SumOfFrequencies)); }
        public double WeightedHarmonicMean { get => SumOfFrequencies / Dataset.Sum(d => d.Y / d.X); }
        public double WeightedQuadraticMean { get => Dataset.Sum(d => (d.Y * Math.Pow(d.X, 2)) / SumOfFrequencies); }
        public double RootMeanSquare { get => Math.Sqrt(WeightedQuadraticMean); }
        public double WeightedCubicMean { get => Dataset.Sum(d => (d.Y * Math.Pow(d.X, 3)) / SumOfFrequencies); }
        public double WeightedBiquadraticMean { get => Dataset.Sum(d => (d.Y * Math.Pow(d.X, 4)) / SumOfFrequencies); }
        public double WeightedLogarithmicMean { get => Dataset.Sum(d => (d.Y * Math.Log10(d.X)) / SumOfFrequencies); }

        public double WeightedRange { get => Dataset.Last().X - Dataset.First().X; }
        public double WeightedMeanDeviation { get => Dataset.Sum(d => (d.Y * Math.Sqrt((Math.Pow(d.X - WeightedAritmeticMean, 2)))) / SumOfFrequencies); }
        public double WeightedVariance { get => Dataset.Sum(d => (d.Y * Math.Pow(d.X - WeightedAritmeticMean, 2)) / SumOfFrequencies); }
        public double WeightedSampleVariance { get => Math.Sqrt(Dataset.Sum(d => d.Y * Math.Pow(d.X - WeightedAritmeticMean, 2)) / (SumOfFrequencies - 1)); }

        public double CoefficientAssimertry { get => Dataset.Sum(d => (d.Y * Math.Pow(d.X - WeightedAritmeticMean, 3)) / (SumOfFrequencies * Math.Pow(WeightedSampleVariance, 3))); }
        public double CoefficientKurtosis { get => Dataset.Sum(d => (d.Y * Math.Pow(d.X - WeightedAritmeticMean, 4)) / (SumOfFrequencies * Math.Pow(WeightedSampleVariance, 4))); }
    }
}
