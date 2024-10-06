using Tyuiu.KosyanovDV.Sprint2.Task3.V2.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tyuiu.KosyanovDV.Sprint2.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression1()
        {
            DataService ds = new DataService();
            double x = 25.0;
            double res = ds.Calculate(x);
            Assert.AreEqual(res, -274.094);
        }

        [TestMethod]
        public void CheckExpression2()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double res = ds.Calculate(x);
            Assert.AreEqual(res, 1.5);
        }

        [TestMethod]
        public void CheckExpression3()
        {
            DataService ds = new DataService();
            double x = 0.0;
            double res = ds.Calculate(x);
            Assert.AreEqual(res, -0.577);
        }

        [TestMethod]
        public void CheckExpression4()
        {
            DataService ds = new DataService();
            double x = -7.0;
            double res = ds.Calculate(x);
            Assert.AreEqual(res, -77);
        }
    }
}