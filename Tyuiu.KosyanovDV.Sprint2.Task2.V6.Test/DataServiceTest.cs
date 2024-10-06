using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KosyanovDV.Sprint2.Task2.V6.Lib;
namespace Tyuiu.KosyanovDV.Sprint2.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMethodCheckInDot()
        {
            DataService ds = new DataService();
            int x = 15;
            int y = 1;
            bool res, expected;
            res = ds.CheckDotInShadedArea(x, y);
            expected = false;
            Assert.AreEqual(expected, res);
        }
    }
}