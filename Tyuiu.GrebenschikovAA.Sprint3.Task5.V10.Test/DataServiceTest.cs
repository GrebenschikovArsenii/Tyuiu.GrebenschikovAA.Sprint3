using Tyuiu.GrebenschikovAA.Sprint3.Task5.V10.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint3.Task5.V10.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            int x = 2, start1 = 1, end1 = 3, start2 = 1, end2 = 10;
            Assert.AreEqual(25.981, ds.GetSumSumSeries(x, start1, start2, end1, end2));
        }
    }
}