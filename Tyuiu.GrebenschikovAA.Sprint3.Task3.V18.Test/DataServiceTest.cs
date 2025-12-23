using Tyuiu.GrebenschikovAA.Sprint3.Task3.V18.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint3.Task3.V18.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReplacingValid()
        {
            DataService ds = new DataService();
            string value = "fifa al fall";
            char item = 'n';
            string res = ds.ReplaceNumOnChar(value, item);
            Assert.AreEqual("fif* *l f*ll", res);
        }
    }
}