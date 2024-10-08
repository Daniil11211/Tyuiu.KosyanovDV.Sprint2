using Tyuiu.KosyanovDV.Sprint2.Task6.V2.Lib;
namespace Tyuiu.KosyanovDV.Sprint2.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckWinter()
        {
            DataService ds = new DataService();
            Assert.AreEqual("зима", ds.FindMonthSeason(1));
            Assert.AreEqual("зима", ds.FindMonthSeason(2));
            Assert.AreEqual("зима", ds.FindMonthSeason(12));
        }

        [TestMethod]
        public void CheckSpring()
        {
            DataService ds = new DataService();
            Assert.AreEqual("весна", ds.FindMonthSeason(3));
            Assert.AreEqual("весна", ds.FindMonthSeason(4));
            Assert.AreEqual("весна", ds.FindMonthSeason(5));
        }

        [TestMethod]
        public void CheckSummer()
        {
            DataService ds = new DataService();
            Assert.AreEqual("лето", ds.FindMonthSeason(6));
            Assert.AreEqual("лето", ds.FindMonthSeason(7));
            Assert.AreEqual("лето", ds.FindMonthSeason(8));
        }

        [TestMethod]
        public void CheckAutumn()
        {
            DataService ds = new DataService();
            Assert.AreEqual("осень", ds.FindMonthSeason(9));
            Assert.AreEqual("осень", ds.FindMonthSeason(10));
            Assert.AreEqual("осень", ds.FindMonthSeason(11));
        }

        [TestMethod]
        public void CheckNotSeasons()
        {
            DataService ds = new DataService();
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthSeason(0);
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthSeason(13);
            });
        }
    }
}