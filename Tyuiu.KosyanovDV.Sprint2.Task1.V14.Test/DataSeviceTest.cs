using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KosyanovDV.Sprint2.Task1.V14.Lib;
namespace Tyuiu.KosyanovDV.Sprint2.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLogicOperations()
        {
            var ds = new DataService();
            int a = 185;
            int b = 216;
            int c = 174;
            int d = 917;
            bool[] expected = new bool[6] { false, true, true, true, true, false };
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(res, expected);
        }
    }
}