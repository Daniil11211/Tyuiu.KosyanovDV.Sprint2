using Tyuiu.KosyanovDV.Sprint2.Task4.V28.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tyuiu.KosyanovDV.Sprint2.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckOperand1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 6;
            var res = ds.Calculate(x, y);
            var wait = 9;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void CheckOperand2()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 1;
            var res = ds.Calculate(x, y);
            var wait = 7.593;
            Assert.AreEqual(res, wait);
        }
    }
}