using Tyuiu.GrebenschikovAA.Sprint3.Task6.V17.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint3.Task6.V17.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SearchingValid()
        {
            DataService ds = new DataService();
            int start = 9, end = 18;
            Assert.AreEqual(95, ds.GetSumTheDivisors(start, end));
        }
    }
}