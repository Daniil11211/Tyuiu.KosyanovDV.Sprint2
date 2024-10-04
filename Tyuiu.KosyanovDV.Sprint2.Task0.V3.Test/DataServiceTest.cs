using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KosyanovDV.Sprint2.Task0.V3.Lib;
namespace Tyuiu.KosyanovDV.Sprint2.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCompare()
        {
            var ds = new DataService();
            int x = 45;
            int y = 127;
            bool[] expected = new bool[6] { false, true, false, true, false, true };
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(res, expected);
        }
    }
}