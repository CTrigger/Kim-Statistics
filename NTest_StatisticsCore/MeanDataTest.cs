using NTest_StatisticsCore.Mockup;
using StastisticsCore;

namespace NTest_StatisticsCore
{
    [TestFixture]
    public class Tests
    {
        private DataCore _dataCore;
        private MeanDataCore _mean;
        [SetUp]
        public void Setup()
        {
            _dataCore = new DataCore();
            _mean = new MeanDataCore();
        }


        [TestCaseSource(typeof(MeanDataMockup), nameof(MeanDataMockup.WeightMockup))]
        public void Scenarios(List<Data> data, List<string> resultList)
        {
            _mean.LoadData(data);
            Assert.True(string.Format("{0:0.000}", _mean.WeightedAritmeticMean) == resultList[0]);
            //Assert.AreEqual(string.Format("{0:0.000}", _mean.WeightedGeometricMean), resultList[1]);
            Assert.True(string.Format("{0:0.000}", _mean.WeightedHarmonicMean) == resultList[2]);
            Assert.True(string.Format("{0:0.000}", _mean.WeightedQuadraticMean) == resultList[3]);
            Assert.True(string.Format("{0:0.000}", _mean.RootMeanSquare) == resultList[4]);
            Assert.True(string.Format("{0:0.000}", _mean.WeightedCubicMean) == resultList[5]);
            Assert.True(string.Format("{0:0.000}", _mean.WeightedBiquadraticMean) == resultList[6]);
            Assert.True(string.Format("{0:0.000}", _mean.WeightedLogarithmicMean) == resultList[7]);

            Assert.True(string.Format("{0:0.000}", _mean.WeightedRange) == resultList[8]);
            Assert.True(string.Format("{0:0.000}", _mean.WeightedMeanDeviation) == resultList[9]);
            Assert.True(string.Format("{0:0.000}", _mean.WeightedVariance) == resultList[10]);
            Assert.True(string.Format("{0:0.000}", _mean.WeightedSampleVariance) == resultList[11]);

            Assert.True(string.Format("{0:0.000}", _mean.CoefficientAssimertry) == resultList[12]);
            Assert.True(string.Format("{0:0.000}", _mean.CoefficientKurtosis) == resultList[13]);
            //MeanDataCore means = _dataCore as MeanDataCore;

            Assert.Pass();
        }
    }
}