using StastisticsCore;

namespace NTest_StatisticsCore
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //[TestCase("[{X=1,Y=2}]",)]
        public void Test1(List<Data> data)
        {
            Assert.Pass();
        }
    }
}