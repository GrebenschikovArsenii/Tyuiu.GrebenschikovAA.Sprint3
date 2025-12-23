using Tyuiu.GrebenschikovAA.Sprint3.Task4.V14.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint3.Task4.V14.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            int start = -5, end = 5;
            double res = ds.Calculate(start, end);
            Assert.AreEqual(-0.858, res);
        }
    }
}