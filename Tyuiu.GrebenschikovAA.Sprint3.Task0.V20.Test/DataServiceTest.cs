using Tyuiu.GrebenschikovAA.Sprint3.Task0.V20.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint3.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 1, end = 9;
            Assert.AreEqual(30991306.832, ds.GetMultiplySeries(start, end));
        }
    }
}