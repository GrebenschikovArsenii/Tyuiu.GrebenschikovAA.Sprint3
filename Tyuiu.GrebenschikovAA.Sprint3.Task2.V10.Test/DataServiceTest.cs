using Tyuiu.GrebenschikovAA.Sprint3.Task2.V10.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint3.Task2.V10.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            double x = 0.25;
            int start = 1, end = 11;
            double res = ds.GetMultiplySeries(x, start, end);
            Assert.AreEqual(13051.340, res);
        }
    }
}