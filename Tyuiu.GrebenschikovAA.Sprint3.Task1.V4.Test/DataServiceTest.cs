using Tyuiu.GrebenschikovAA.Sprint3.Task1.V4.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint3.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            int x = 5, startValue = 1, endValue = 17;
            double res = ds.GetSumSeries(startValue, endValue);
            Assert.AreEqual(0.168, res);
        }
    }
}